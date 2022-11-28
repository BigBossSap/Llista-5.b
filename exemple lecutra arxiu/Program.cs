using System;
using System.IO;

namespace exemple_lecutra_arxiu
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fitxerR = new StreamReader(@"C:\Users\soc\Desktop\numeros.txt");
            while (!fitxerR.EndOfStream)
            {
                Console.WriteLine(fitxerR.ReadLine());
            }

            fitxerR.Close();
        }
    }
}
