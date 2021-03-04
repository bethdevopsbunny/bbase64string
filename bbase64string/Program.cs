using System;
using StringStuffLibrary;

namespace bbase64string
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedString;
            string toEncode;
            bool isShow = false;
            bool isRaw = false;
            string providedString
;

            StringWorker stringWorker = new StringWorker();

            toEncode = stringWorker.GetRandomString();

            if (args.Length != 0)
            {

                foreach(string arg in args)
                {
                    if(arg == "--help")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("##################################");
                        Console.WriteLine("random base64 string generator by Beth Donachie");
                        Console.WriteLine("");
                        Console.WriteLine("arguments:");
                        Console.WriteLine("'--input' - will add passed text to the string before encoding");
                        Console.WriteLine("'--raw' - removes the fluff from the response just gives you the code");
                        Console.WriteLine("'--show' - shows you the pre encoded string");
                        Console.WriteLine("##################################");
                        Console.WriteLine("");
                        Environment.Exit(0);
                    }
                }

                for (int i =0; i < args.Length; i++)
                {

                    if(args[i] == "--raw")
                    {
                        isRaw = true;
                    }
                    
                    if(args[i] == "--show")
                    {
                        isShow = true;
                    }

                    if(args[i] == "--input")
                    {
                        providedString = args[i + 1];


                        if(providedString.Length > 44)
                        {
                            toEncode = providedString.Substring(0, 44);
                        }
                        else if(providedString.Length < 44){

                            string padRandom = stringWorker.GetRandomString(44 - providedString.Length);
                    
                            toEncode = providedString + padRandom;

                        }
                        else if (providedString.Length == 44)
                        {
                            toEncode = providedString;
                        }
                        else
                        {
                            toEncode = stringWorker.GetRandomString();
                        }


                    }
       

                }
   

            }


            if (isRaw)
            {
                Console.WriteLine(toEncode);
                Environment.Exit(0);
            }
 


            if (isShow)
            {
                Console.WriteLine("");
                Console.WriteLine($"pre encoded string: {toEncode}");
               
            }
         
            encodedString = stringWorker.EncodeString(toEncode);
            Console.WriteLine("");
            Console.WriteLine($"encoded string: {encodedString}");
            Console.WriteLine("");


        }



    }
}
