using System;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5. Fer un programa que demani una frase i l’escrigui sense espais múltiples  */


            char frase;
            string completa = "";

            Console.WriteLine("frase: ");
            frase = Console.ReadKey().KeyChar;

            do
            {
                


                if (frase == ' ')
                {
                    

                    while (frase == ' ')
                    {
                        frase -= ' ';
                        frase = Console.ReadKey().KeyChar;
                    }
                }

                completa = completa + frase;
                frase = Console.ReadKey().KeyChar;
            } while (frase != '.');

            Console.WriteLine(completa);






        }
    }
}
