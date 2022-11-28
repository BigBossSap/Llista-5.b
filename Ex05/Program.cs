using System;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*5. Fer un programa que demani una frase i l’escrigui sense espais múltiples  */


            int con = 0;
            char lletra;
            char ant = ' ';
            string frase ="";

            lletra = (char)Console.Read();

            while (lletra != '.')
            {
                if (lletra >= 'a' && lletra <= 'z')
                    frase += lletra;
                else if ((ant >= 'a' && ant <= 'z') && lletra != ' ')
                    frase += lletra;
                    
            }

            Console.WriteLine(frase);






        }
    }
}
