using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._16
{
    internal class DirectoryWorker
    {
        private string path = string.Empty;

        public void FilesInDirectory()
        {
            DirectoryInfo directory= new DirectoryInfo(path);
            var value = directory.GetFiles();
            Console.WriteLine(value.Length);
        }

        public void FilesInCat()
        {
            var fileCount = (from file in Directory.EnumerateFiles(path, "" , SearchOption.AllDirectories)
                             select file).Count();
            Console.WriteLine($"there is {fileCount} files in {path}");
            Console.WriteLine();
        }

        public void DirectoryFileInfo()
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            var value = directory.GetFiles();
            foreach(var file in value)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine($"{file.Length} bytes");
                Console.WriteLine();
            }
        }

        public void CountCatExtFiles(string fileExtension)
        {
                var fileCount = (from file in Directory.EnumerateFiles(path, fileExtension, SearchOption.AllDirectories)
                                 select file).Count();
                Console.WriteLine($"there is {fileCount} files in {path} with {fileExtension} extension");
                Console.WriteLine();

        }

        public void CountDirExtFiles(string fileExtension)
        {

                var fileCount = (from file in Directory.EnumerateFiles(path, fileExtension, SearchOption.TopDirectoryOnly)
                                 select file).Count();
                Console.WriteLine($"there is {fileCount} files in {path} with {fileExtension} extension");
                Console.WriteLine();

        }

        public string ReturnPath()
        {
            return path;
        }

        public void SetPath(string path)
        {
            this.path = path;
        }


    }
}
