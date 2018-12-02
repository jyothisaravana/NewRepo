using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\Student\\Desktop\\C# project\\hello.txt");

                sw.WriteLine("Hello world! This is c# project");
                sw.Close();
              
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:", e.Message);
            }

            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\Student\\Desktop\\C# project\\hello.txt");
                
                line = sr.ReadLine();
                 while(line!=null)
                 {
                    Console.WriteLine(line);
                    line = sr.ReadLine();

                 }
                sr.Close();
               
                Console.ReadLine();

            }
            catch(Exception e)
            {
                Console.WriteLine("Exception:",e.Message);
            }

            

        }
    }
}
