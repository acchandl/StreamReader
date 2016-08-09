using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shakespeare_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //problem 1- read the first line from the file

            StreamReader reader = new StreamReader("shakespeare.txt");
            using (reader)

            {
               
                string line = reader.ReadLine();
                Console.WriteLine(line);

            }
            */





            /*
            //problem 2- read entire text file

            StreamReader reader = new StreamReader("shakespeare.txt");
            using (reader)

            {
                int lineNumner = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumner++;
                        Console.WriteLine("Line{0}:{1}", lineNumner, line);
                    line = reader.ReadLine();
                }
            }

    */


            // problem 3- read entire text file and capitalize all lowercase vowels.
            //didnt finish this problen, but this is my thought process


            StreamReader reader = new StreamReader("shakespeare.txt");
            using (reader)

            {
                int i = 0;
                string line = reader.ReadLine();




                while (line != null)
                {
                    i++;
                    Console.WriteLine("Line{0}:{1}", i, line);
                    line = reader.ReadLine();
                }
            }

        }

        static string Lower(string a)
        {
            if (string.Contains(a))
            {
                return string;
            }
            return char.ToUpper(a[0] + a.Substring(1));
        }
            



        
    }
}
