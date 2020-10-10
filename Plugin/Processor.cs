using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Security.Cryptography;
using Unbroken.LaunchBox.Plugins;
using Unbroken.LaunchBox.Plugins.Data;
using System.IO.Compression;
using System.IO;

namespace Pamput.NoIntroLBPlugin
{
    class NoIntroLBProcessor
    {
        private string Platform;

        public Dictionary<string, XmlNode> Md5ToNoIntroMap { get; } = new Dictionary<string, XmlNode>();
        public Dictionary<string, XmlNode> NameToNoIntroMap { get; } = new Dictionary<string, XmlNode>();

        private XmlDocument _noIntroXml;

        public NoIntroLBProcessor(string platform, string noIntroXmlFile)
        {
            Platform = platform;

            LoadNoIntroXml(noIntroXmlFile);
        }

        private void LoadNoIntroXml(string noIntroXmlFile)
        {
            _noIntroXml = new XmlDocument();
            _noIntroXml.Load(noIntroXmlFile);

            XmlNode root = _noIntroXml.DocumentElement;

            XmlNodeList gameList = root.SelectNodes("//game");

            foreach (XmlNode game in gameList)
            {
                NameToNoIntroMap.Add(game.Attributes["name"].Value, game);
                Md5ToNoIntroMap.Add(game.SelectSingleNode("./rom").Attributes["md5"].Value, game);
            }
        }

        public Result Process(IProgress<ProcessProgress> progress = null)
        {
            Result result = new Result();

            IDataManager dm = PluginHelper.DataManager;
            IPlatform platform = dm.GetPlatformByName(Platform);

            IGame[] games = platform.GetAllGames(true, true);
            List<IGame> clones = new List<IGame>();
            List<IGame> parents = new List<IGame>();

            Dictionary<IGame, XmlNode> lb2niMap = new Dictionary<IGame, XmlNode>();
            Dictionary<XmlNode, IGame> ni2lbMap = new Dictionary<XmlNode, IGame>();

            ProcessProgress state = new ProcessProgress()
            {
                TotalGames = games.Length
            };

            Report(progress, state);

            foreach (IGame game in games)
            {
                string path = game.ApplicationPath;
                state.CurrentGame = path;

                try
                {
                    string md5 = RomIOHelper.GetMD5(path);

                    XmlNode niGame = Md5ToNoIntroMap[md5];

                    if (niGame == null)
                    {
                        result.Skipped.Add(Tuple.Create(path, $"md5 ({md5}) doesn't match any entry"));
                        continue;
                    }

                    if (niGame.Attributes["cloneof"] != null)
                    {
                        clones.Add(game);
                    }
                    else
                    {
                        parents.Add(game);
                    }

                    lb2niMap.Add(game, niGame);
                    ni2lbMap.Add(niGame, game);
                }
                catch (Exception e)
                {
                    result.Skipped.Add(Tuple.Create(path, e.Message));
                }

                state.ProcessedGames++;
                Report(progress, state);
            }

            state.GamesScanFinished = true;
            state.TotalClones = clones.Count;
            state.CurrentGame = "";
            Report(progress, state);

            foreach (IGame clone in clones)
            {
                string path = clone.ApplicationPath;
                state.CurrentGame = path;

                dm.TryRemoveGame(clone);

                string parentName = lb2niMap[clone].Attributes["cloneof"].Value;
                string cloneName = lb2niMap[clone].Attributes["name"].Value;

                IGame parent = ni2lbMap[NameToNoIntroMap[parentName]];

                IAdditionalApplication additionalApplication = parent.AddNewAdditionalApplication();

                additionalApplication.ApplicationPath = clone.ApplicationPath;
                additionalApplication.Name = $@"Play {cloneName}";

                state.ProcessedClones++;
                Report(progress, state);
            }

            state.CloneProcessFinished = true;
            Report(progress, state);
            
            dm.Save();

            return result;
        }

        public async Task<Result> ProcessAsync(IProgress<ProcessProgress> progress = null) =>
            await new Task<Result>(() => Process(progress));

        private void Report(IProgress<ProcessProgress> progress, ProcessProgress state)
        {
            if (progress != null && state != null)
            {
                progress.Report(state);
            }
        }
    }

    internal class Result
    {
        public List<Tuple<string, string>> Skipped { get; set; } = new List<Tuple<string, string>>();
    }

    public class ProcessProgress
    {
        public bool GamesScanFinished { set; get; }
        public int TotalGames { set; get; }
        public int ProcessedGames { set; get; }
        public int TotalClones { set; get; }
        public int ProcessedClones { set; get; }
        public string CurrentGame { set; get; } = "";

        public bool CloneProcessFinished { set; get; }
    }
}