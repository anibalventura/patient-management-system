using System;
using System.IO;

namespace FileHandler
{
    public class FileSaver
    {
        public string SaveFile(string fileName, string directory)
        {
            try
            {
                if (!string.IsNullOrEmpty(fileName))
                {
                    string[] fileNameSplit = fileName.Split(@"\");
                    string filename = fileNameSplit[(fileNameSplit.Length - 1)];

                    CreateDirectory(directory);

                    string destination = directory + filename;

                    File.Copy(fileName, destination, true);

                    return destination;
                }

                return null;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        private void CreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}
