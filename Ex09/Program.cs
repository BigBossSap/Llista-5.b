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

                if (frase >= 'A' && frase <= 'Y')
                {
                    frase++;
                    fraseFinal += frase;
                    
                }

                
                if (frase=='Z')
                {
                    frase = 'a';
                    fraseFinal += frase;
                   
                }
                

                if (frase >= 'a' && frase <= 'y')
                {
                    frase++;
                    fraseFinal += frase;
                    
                }
                

                if (frase=='z')
                {
                    frase = 'A';
                    fraseFinal += frase;
                    

                }
               
                frase = Console.ReadKey().KeyChar;



                

            }

            Console.WriteLine(fraseFinal);
        }
    }
}
