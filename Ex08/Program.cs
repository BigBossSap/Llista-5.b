using System;
using System.Diagnostics;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*8. Fer un programa que demani una frase i digui si hi ha algun diftong. Són diftongs els
 grups de vocal més vocal feble (i, u) excepte ii.  */

            char frase;
            char lletra;
            int contador = 0;

            Console.WriteLine("Frase: ");
            frase = Console.ReadKey().KeyChar;

            while (frase != '.')
            {
                if (frase == 'a' || frase == 'e' || frase == 'o' || frase == 'u')
                {
                    frase = Console.ReadKey().KeyChar;
                    if (frase == 'u' || frase == 'i' && frase != '.')
                    
                        contador++;
                       
                    

                    }


                if (frase == 'u' || frase == 'i')
                {
                    frase = Console.ReadKey().KeyChar;
                    if (frase == 'a' || frase == 'e' || frase == 'o' || frase == 'u' && frase != '.')
                        contador++;
                }
                frase = Console.ReadKey().KeyChar;
            }
            
            if (contador==0)
                Console.WriteLine("No hi ha diftongs.");
            else
                Console.WriteLine($"Hi han {contador} diftongs.");
            
            


        }
    }
}
