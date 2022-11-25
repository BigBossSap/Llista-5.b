using System;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 6. Fes un programa que et demani:
   Comprovar si majúscules. Escriu una frase i acaba si troba alguna majúscula la
   text i ens diu quina és.
   Passar a majúscules. Escriu una frase i la mostra en majúscules. Comprovar si el
   caràcter ja és majúscula.  */


            char lletra;
            string frase = "";

            Console.WriteLine("frase: ");
            lletra = Console.ReadKey().KeyChar;

            while (lletra!='.')
            {

                if (lletra >= 'A' && lletra <= 'Z' || lletra == ' ')
                    frase += lletra;
                else
                    frase += (char)(lletra - 32);

                lletra = Console.ReadKey().KeyChar;

            }

            Console.WriteLine($"\r La frase en majuscules es: {frase}");

        }
    }
}
