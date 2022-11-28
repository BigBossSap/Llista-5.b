using System;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7. Fer un programa que demani una frase i compti els diftongs. Són diftongs els grups
de vocal més vocal feble (i, u) excepte ii.  */

            char frase;
            char lletra;
            int contador=0;

            Console.WriteLine("Frase: ");
            frase = Console.ReadKey().KeyChar;

            while(frase!='.')
            {

                if (frase == 'a' || frase == 'e'  || frase == 'o' || frase == 'u')
                {
                    frase = Console.ReadKey().KeyChar;

                    if (frase == 'u' || frase == 'i')
                        contador++;
                }
                
                
                if (frase == 'u' || frase == 'i')
                 {
                    frase = Console.ReadKey().KeyChar;

                    if (frase == 'a' || frase == 'e' || frase == 'o' || frase == 'u')
                            contador++;
                 }
                
                
                    




                    frase = Console.ReadKey().KeyChar;
                

            }

            Console.WriteLine(contador);
        }
    }
}
