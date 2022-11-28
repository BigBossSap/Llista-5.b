using System;
using System.IO;

namespace Exemple_escriptura_i_lectura
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            StreamReader fitxerR = new StreamReader(@"C:\Users\soc\Desktop\numeros.txt");
            StreamWriter fitxerW = new StreamWriter(@"C:\Users\soc\Desktop\numfinals.txt");
            while (!fitxerR.EndOfStream)
            {
                num = Convert.ToInt32(fitxerR.ReadLine());
                if (num > 4)
                    fitxerW.WriteLine(num);

            }

            fitxerW.Close();
            fitxerR.Close();
        }
    }
}
