using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    

namespace ConAppDirectoryEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=======Folder creation Example========================
            //string fFolder = "F:\\";
            //string newDir;
            //Console.WriteLine("Enter New Directory Name");
            //newDir=Console.ReadLine();
            //string fPath=fFolder + "/" + newDir;
            //DirectoryInfo directoryInfo=new DirectoryInfo(fPath);
            //if(directoryInfo.Exists )
            //{
            //    Console.WriteLine($"Directory {newDir} already exist");
            //}
            //else
            //{
            //    directoryInfo.Create();
            //    Console.WriteLine($"Directory {newDir} creation on {fPath} success");
            //}
            //Console.ReadKey();

            // ==============DirectoryInfo Example====================
            string fpath;
            Console.WriteLine("Enter directory Path");
            fpath=Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(fpath);
            foreach (FileInfo fi in di.GetFiles())
            {
                Console.Write("File Name:\t"+fi.FullName);
                Console.Write("\t File Length"+fi.Length);
                Console.Write("\t File creation Time"+fi.CreationTime);
                Console.WriteLine("\n");

            }
            Console.ReadKey();
        }
    }
}
