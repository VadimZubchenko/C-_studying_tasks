using System;
using System.IO;

namespace Tehtava11_2_2_try_catch_FileNotFoundException
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = "";
            string rivi = null;
            try
            {

                Console.WriteLine("Anna tiedoston nimi:");
                tiedosto = Console.ReadLine();

                FileStream fInStream = File.OpenRead(tiedosto);
                StreamReader sReader = new StreamReader(fInStream);

                while ((rivi = sReader.ReadLine()) != null)
                {
                    Console.WriteLine(rivi);
                }
                sReader.Close();
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Tiedostoa ei löytynyt nimellä " + tiedosto);
                
            }
        }
    }
}

