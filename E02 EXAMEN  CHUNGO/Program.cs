using System;

namespace E02_EXAMEN__CHUNGO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.- Fer un programa que ens permet escriure una frase completa acabada en intro ‘\r’.
   Haurem d’analitzar la frase caràcter a caràcter amb Console.Read().
   Ens indique la mitjana de paraula, la longitud màxima de paraula i paraula màxima. Per a
   saber que hem detectat una paraula haurem de mirar que el caràcter anterior sigui una lletra
   i l’actual no sigui una lletra.
   Signes de puntuació, espais, números, … no són paraula QUALSEVOL COSA QUE NO
   SIGUI UNA LLETRA NO ÉS PART DE LA PARAULA (no conteu accents).
   Ex: hola, com estas?
   té 3 paraules, que són hola com estas
   ha de mostrar per pantalla:
   mitjana de paraula 4, longitud màxima 5 la paraula es estas
   Ex2: 342hola,,,, ,,, ??? com,,, estas43_--- ;
   té 3 paraules, que són hola com estas
   ha de mostrar per pantalla:
   mitjana de paraula 4, longitud màxima 5 la paraula es estas*/


            char caracter;
            Console.WriteLine("Frase: ");
            caracter = Console.ReadKey().KeyChar;

            while (caracter != '\r')
            {


            }

        }
    }
}
