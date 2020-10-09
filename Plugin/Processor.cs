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

        private XmlDocument NoIntroXML;

        public NoIntroLBProcessor(string platform, string noIntroXmlFile)
        {
            Platform = platform;

            LoadNoIntroXml(noIntroXmlFile);
        }

        private void LoadNoIntroXml(string noIntroXmlFile)
        {
            NoIntroXML = new XmlDocument();
            NoIntroXML.Load(noIntroXmlFile);

            XmlNode root = NoIntroXML.DocumentElement;

            XmlNodeList gameList = root.SelectNodes("//game");

            foreach (XmlNode game in gameList)
            {
                NameToNoIntroMap.Add(game.Attributes["name"].Value, game);
                Md5ToNoIntroMap.Add(game.SelectSingleNode("./rom").Attributes["md5"].Value, game);
            }
        }

        public Result Process()
        {
            Result result = new Result();

            IDataManager dm = PluginHelper.DataManager;
            IPlatform platform = dm.GetPlatformByName(Platform);

            IGame[] games = platform.GetAllGames(true, true);
            List<IGame> clones = new List<IGame>();
            List<IGame> parents = new List<IGame>();

            Dictionary<IGame, XmlNode> lb2niMap = new Dictionary<IGame, XmlNode>();
            Dictionary<XmlNode, IGame> ni2lbMap = new Dictionary<XmlNode, IGame>();

            foreach (IGame game in games)
            {
                string path = game.ApplicationPath;

                try
                {
                    string md5 = RomIOHelper.GetMD5(path);

                    XmlNode niGame = Md5ToNoIntroMap[md5];

                    if (niGame == null)
                    {
                        result.Skipped.Add(Tuple.Create(path, String.Format("md5 ({0}) doesn't match any entry", md5)));
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
            }

            foreach (IGame clone in clones)
            {
                dm.TryRemoveGame(clone);

                string parentName = lb2niMap[clone].Attributes["cloneof"].Value;
                string cloneName = lb2niMap[clone].Attributes["name"].Value;

                IGame parent = ni2lbMap[NameToNoIntroMap[parentName]];

                IAdditionalApplication additionalApplication = parent.AddNewAdditionalApplication();

                additionalApplication.ApplicationPath = clone.ApplicationPath;
                additionalApplication.Name = cloneName;
            }

            dm.Save();

            return result;
        }
    }

    class Result
    {
        public List<Tuple<string, string>> Skipped { get; set; } = new List<Tuple<string, string>>();
    }
}