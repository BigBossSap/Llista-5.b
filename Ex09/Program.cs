using System;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9. Demanar una frase i codificar‐la, fent correspondre a cada lletra el següent caràcter.
   A la z la a*/

            char frase;
            string fraseFinal="";

            Console.WriteLine("Frase: ");
            frase = Console.ReadKey().KeyChar;

            while (frase != '\r')
            {

                frase --;
                fraseFinal += frase;


                frase = Console.ReadKey().KeyChar;

            }

            Console.WriteLine(fraseFinal);
        }
    }
}
