using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pamput.NoIntroLBPlugin
{
    class RomIOHelper
    {
        public static string GetMD5(string filename)
        {
            if (Path.GetExtension(filename).ToLower().Equals(".zip"))
            {
                return GetZipMD5(filename);
            }
            else
            {
                return GetSimpleMD5(filename);
            }
        }

        private static string GetSimpleMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private static string GetZipMD5(string filename)
        {
            using (FileStream zipToOpen = new FileStream(filename, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                {
                    if (archive.Entries.Count() > 1)
                    {
                        throw new Exception(
                            String.Format(
                                "{0} is a zip file but doesn't contain only 1 file",
                                filename
                            )
                        );
                    }

                    using (var md5 = MD5.Create())
                    {
                        using (var stream = archive.Entries.First().Open())
                        {
                            var hash = md5.ComputeHash(stream);
                            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                        }
                    }
                }
            }
        }
    }
}