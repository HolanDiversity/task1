using System;
using System.Collections.Generic;


namespace ConsoleApp5
    {
        class Program
        {
            static void Main(string[] args)
            {

                Dictionary<string, string> JSON = new Dictionary<string, string>();
                int i = 1;


                char[] Symb = { '"', '"' };
                string Txt = Console.ReadLine();
                string Result = Txt.Trim(Symb);

            if (i % 2 != 0) {
                string Key = Result;
            }
            else {
                string Value = Result;
                JSON.Add(Key, Value);
            };
            
                
            Console.WriteLine(Result);
            foreach (KeyValuePair<string, string> keyValue in JSON) ;
            {



            }
            Console.ReadKey();

            }
        }
    }


