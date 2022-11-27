using System;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. Fer un programa que demani una frase i escrigui el percentatge de vocals respecte al
   de consonants  */


            char lletra;
            double contVocal=0, contConsonants=0;

            Console.WriteLine("Frase, acaba amb un punt: ");
            lletra=Console.ReadKey().KeyChar;

            while (lletra != '.')
            {
                if (lletra == 'A' || lletra == 'E' || lletra == 'I' || lletra == 'O'
                    || lletra == 'U' || lletra == 'a' || lletra == 'e' || lletra == 'i' || lletra == 'o' || lletra == 'u')
                    contVocal++;
              
                else if (lletra != ' ' && lletra != '.')
                    contConsonants++;




                lletra = Console.ReadKey().KeyChar;
            }

            double percentatjeVocals = contVocal * 100/ (contVocal + contConsonants);
            double percentatjeConsonants = contConsonants * 100 / (contVocal + contConsonants);

            Console.WriteLine();
            Console.WriteLine($"La frase te {contVocal} vocals que es un {Math.Round(percentatjeVocals,2)}% i {contConsonants} consonants que es un {Math.Round(percentatjeConsonants,2)}%.");
           



        }
    }
}
