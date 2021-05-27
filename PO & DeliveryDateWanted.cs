using System;
using System.IO;

namespace EDI_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            POchecker();
            Console.ReadLine();

        }

       public static void POchecker()
        {
            
            string path = @"Your Path";

            try
            {
                string[] dirs = Directory.GetFiles(path);

                Console.WriteLine($"Number of Files in Path ={dirs.Length}");

                foreach (var file in dirs)
                {
                    string order = File.ReadAllText(file);

                    var spliter = order.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Console.Write(spliter[0] + " ");
                    Console.WriteLine(spliter[5].Substring(0,8));
           
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
            
        
    }
}
