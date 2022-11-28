using System;

namespace Ex06.b
{
    class Program
    {
        static void Main(string[] args)
        {

            /*6. Fes un programa que et demani:
   Comprovar si majúscules. Escriu una frase i acaba si troba alguna majúscula la
   text i ens diu quina és.*/


            char lletra;
            char majuscula;

            Console.WriteLine("frase: ");
            lletra = Console.ReadKey().KeyChar;

            while (lletra >= 'a' && lletra <='z' || lletra == ' ')
            {


                if (lletra >= 'A' && lletra <= 'Z')
                    majuscula = lletra;



               lletra = Console.ReadKey().KeyChar;

            }

            Console.WriteLine($"\r La majuscula es: {lletra}");
        }
    }
}
