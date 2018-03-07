using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace EncryptUtilityForMSBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"input.txt");

            Class1 c = new Class1();
            string encryptString = c.Encrypt(text);

            //Write to a file
            using (StreamWriter writer = new StreamWriter(@"output.txt"))
            {
                writer.WriteLine(encryptString);
            }

            


        }
    }
}
