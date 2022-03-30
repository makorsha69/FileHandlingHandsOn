using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandling fileHandling = new FileHandling();
            //fileHandling.WriteFile();
            Console.WriteLine("Detailed");
            Console.WriteLine("");
            fileHandling.ReadFile();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            //Console.Read();

            SuccessFileHandling successFile = new SuccessFileHandling();
            Console.WriteLine("Success");
            Console.WriteLine("");
            successFile.ReadFile();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");


            FailedFileHandling failedFile = new FailedFileHandling();
            Console.WriteLine("Failed");
            Console.WriteLine("");
            failedFile.ReadFile();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");


            MissedFileHandling missedFile = new MissedFileHandling();
            Console.WriteLine("Missed");
            Console.WriteLine("");
            missedFile.ReadFile();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");


            DialledFileHandling dialledFile = new DialledFileHandling();
            Console.WriteLine("Dialled");
            Console.WriteLine("");
            dialledFile.ReadFile();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.Read();
        }
    }
}