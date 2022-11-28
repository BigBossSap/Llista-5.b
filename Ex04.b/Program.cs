using System;
using System.Threading.Tasks;

namespace Ex04.b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Fer un programa que demani una frase i digui quantes paraules hi ha.  
      a. Versió 1. Suposeu que no hi ha espais innecessaris.  
      b. Versió 2. Suposeu que pot haver espais al principi, al final, espais dobles, ...  */

            char lletra;
            int cont = 1;                                        
            Console.WriteLine("Frase, acaba en punt: ");
            lletra = Console.ReadKey().KeyChar;

            while (lletra == ' ')
                lletra = Console.ReadKey().KeyChar;

            do



            {
                if (lletra == ' ')
                {
                    cont++;
                    lletra = Console.ReadKey().KeyChar;
                }
                while (lletra == ' ')

                    lletra = Console.ReadKey().KeyChar;

                lletra = Console.ReadKey().KeyChar;
            } while (lletra != '.');

            if (lletra == ' ')
                cont--;


            Console.WriteLine($"La frase te {cont} paraules.");

        }
            
            
        }
    }

