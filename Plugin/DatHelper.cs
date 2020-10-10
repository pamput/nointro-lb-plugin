using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Unbroken.LaunchBox.Plugins;
using Unbroken.LaunchBox.Plugins.Data;

namespace Pamput.NoIntroLBPlugin
{
    public class DatHelper
    {
        public static string GetDatDirectory()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var datDirectory = Path.Combine(currentDirectory, "DATs");

            if (!Directory.Exists(datDirectory))
            {
                Directory.CreateDirectory(datDirectory);
            }

            return datDirectory;
        }

        public static string[] GetDatFiles()
        {
            return Directory
                .GetFiles(GetDatDirectory())
                .Where(path => Path.GetExtension(path).ToLower().Equals(".dat"))
                .ToArray();
        }

        public static string[] GetImportedPlatforms()
        {
            var platforms = PluginHelper
                .DataManager.GetAllPlatforms()
                .Select(p => p.Name)
                .ToHashSet();

            var datFiles = GetDatFiles();
            var datPlatforms = datFiles.Select(path => Path.GetFileNameWithoutExtension(path)).ToHashSet();

            return datPlatforms.Where(dat => datPlatforms.Contains(dat)).ToArray();
        }

        public static bool IsImportedPlatform(string platform)
        {
            return GetImportedPlatforms().Contains(platform);
        }

        public static string GetPlatformDatFile(string platform)
        {
            if (!IsImportedPlatform(platform))
            {
                return null;
            }

            return GetDatFiles()
                .Single(path => Path.GetFileNameWithoutExtension(path).Equals(platform))
                .ToString();
        }

        public static string ImportDat(string path, string platform)
        {
            var datDirectory = GetDatDirectory();
            var datFile = Path.Combine(datDirectory, $@"{platform}.dat");

            if (Path.GetExtension(path).ToLower().Equals(".zip"))
            {
                using (FileStream zipFile = new FileStream(path, FileMode.Open))
                {
                    var zip = new ZipArchive(zipFile);

                    if (zip.Entries.Count != 1)
                    {
                        throw new Exception("Zip file contains more than one entry");
                    }

                    using (FileStream output = File.OpenWrite(datFile))
                    {
                        using (Stream input = zip.Entries.First().Open())
                        {
                            input.CopyTo(output);
                        }
                    }

                }
            }
            else
            {
                if (File.Exists(datFile))
                {
                    File.Delete(datFile);
                }
                
                File.Copy(path, datFile);
            }

            return datFile;
        }
    }
}