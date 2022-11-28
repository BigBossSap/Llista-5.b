using System;
using System.IO;
namespace Exemple_lectura_i_escriptura_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string paraula;
            StreamReader fitxerR = new StreamReader(@"C:\Users\soc\Desktop\paraules.txt");
            StreamWriter fitxerW = new StreamWriter(@"C:\Users\soc\Desktop\paraulesFinals.txt", true);
            while (!fitxerR.EndOfStream)
            {
                paraula = fitxerR.ReadLine();
                if (paraula.Length > 4)
                    fitxerW.WriteLine(paraula);

            }

            fitxerW.Close();
            fitxerR.Close();
        }
    }
}
