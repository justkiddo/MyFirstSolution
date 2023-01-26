using Homework_1._17;
using System.IO;

string dirPath = "F:\\TestDirectory2\\";

var file1 = new FileInfo("Text1.txt");
var file2 = new FileInfo("Text2.txt");
var file3 = new FileInfo("Empty.txt");

var writeStream1 = new FileStream($"{dirPath}{file1}", FileMode.Create, FileAccess.Write);
var writeStream2 = new FileStream($"{dirPath}{file2}", FileMode.Create, FileAccess.Write);
var writeStream3 = new FileStream($"{dirPath}{file3}", FileMode.Create, FileAccess.Write);

string first = "some kind of text1";
string second = "other kind of text2";

StreamWriter sw1 = new StreamWriter(writeStream1);
StreamWriter sw2 = new StreamWriter(writeStream2);

sw1.WriteLine(first);
sw2.WriteLine(second);

sw1.Close();
sw2.Close();
writeStream1.Close();
writeStream2.Close();
writeStream3.Close();

Thread t1 = new Thread(TextWorker.ActionOne);
t1.Start();
t1.Join();
Thread t2= new Thread(TextWorker.ActionTwo);
t2.Start();