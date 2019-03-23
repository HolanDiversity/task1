using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace ConsoleApp5
    {
        class Program
        {
        static void Main(string[] args)
        {

            //string s = Console.ReadLine();
            //int count = 0;
            //foreach (Match m in Regex.Matches(s, ","))
            //    count++;
            //Console.WriteLine(count);





            string words = Console.ReadLine();
            words = words.Replace(",", ",|").Replace("{", "{|").Replace("\"}", "\"|}");
            string[] split = words.Split(new Char[] { '|' });


            foreach (string ss in split)
            {
                if (ss.Trim() != "")
                    Console.WriteLine(ss);
            }


            Console.ReadKey();

        }
    }
    }


