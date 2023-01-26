using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._17
{
    internal class TextWorker
    {

        public static void ActionOne()
        {
            Console.WriteLine("поток 1 запущен");
            string dirPath = "F:\\TestDirectory2\\";
            var file1 = new FileInfo("Text1.txt");
            var file3 = new FileInfo("Empty.txt");

            FileStream readStream = new FileStream($"{dirPath}{file1}", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(readStream);
            string res = sr.ReadToEnd();

            FileStream writeStream = new FileStream($"{dirPath}{file3}", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(writeStream);
            sw.WriteLine(res);
            sw.Close();
            writeStream.Close();
        }

        public static void ActionTwo()
        {
            Console.WriteLine("поток 2 запущен");
            string dirPath = "F:\\TestDirectory2\\";
            var file1 = new FileInfo("Text2.txt");
            var file3 = new FileInfo("Empty.txt");

            FileStream readStream1 = new FileStream($"{dirPath}{file1}", FileMode.Open, FileAccess.Read);
            FileStream readStream2 = new FileStream($"{dirPath}{file3}", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(readStream1);
            StreamReader sr2 = new StreamReader(readStream2);
            string res = sr2.ReadToEnd();
            res += sr.ReadToEnd();
            sr.Close();
            sr2.Close();

            FileStream writeStream = new FileStream($"{dirPath}{file3}", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(writeStream);
            sw.WriteLine(res);
            sw.Close();
            writeStream.Close();
        }
    }
}
