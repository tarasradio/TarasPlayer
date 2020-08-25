using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarasPlayer
{
    public class FileManager
    {
        public string CurrentDirectory { get; set; } = string.Empty;
        public List<string> OpenFiles { get; set; }
        public string CurrentFile { get; set; } = string.Empty;
        public int CurrentIndex { get; set; } = 0;

        public FileManager()
        {
            OpenFiles = new List<string>();
        }

        public void OpenFile(string fileName)
        {
            CurrentDirectory = System.IO.Path.GetDirectoryName(fileName);

            OpenFiles = System.IO.Directory.GetFiles(
                CurrentDirectory,
                "*.mp3",
                System.IO.SearchOption.TopDirectoryOnly).ToList<string>();

            for(int i = 0; i < OpenFiles.Count; i++)
            {
                OpenFiles[i] = 
                    System.IO.Path.GetFileNameWithoutExtension(OpenFiles[i]);

                if (OpenFiles[i] == System.IO.Path.GetFileNameWithoutExtension(fileName))
                {
                    CurrentIndex = i;
                }
            }
                
        }

        public string GetFileName()
        {
            return OpenFiles[CurrentIndex];
        }
    }
}
