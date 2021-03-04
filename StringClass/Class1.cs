using System;

namespace StringStuffLibrary
{
    public class StringWorker
    {

        private string characters { get; } = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@~!@$%^&*():;[]{}<>,.";

       

        public string GetRandomString(int sizeOfString = 44 )
        {
            string returnString = "";

  
            for (int i = 0; i < sizeOfString; i++)
            {


                Random r = new Random();
                int rInt = r.Next(0, characters.Length);
                returnString = returnString.Insert(0, characters[rInt].ToString());

            }

            return returnString;
        }



        public string EncodeString(string toEncode)
        {

            string encodedString;

            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(toEncode);

            encodedString =  Convert.ToBase64String(plainTextBytes);

            return encodedString;
        }

    }
}
