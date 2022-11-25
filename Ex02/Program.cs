using System;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Fer un programa que demani una frase lletra a lletra i digui quantes vocals té.
   */

            char lletra;
            int contVocal = 0;

            Console.WriteLine("Introduex una frase lletra a lletra, acaba amb un 0:");
            lletra = Convert.ToChar(Console.ReadLine());

            while (lletra!='0')

            {

                if (lletra == 'A' || lletra == 'E' || lletra == 'I' || lletra == 'O'
                    || lletra == 'U' || lletra == 'a' || lletra == 'e' || lletra == 'i' || lletra == 'o' || lletra == 'u')
                    contVocal++;

                lletra = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine(contVocal);

        }
    }
}
