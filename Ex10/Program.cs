using System;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10. Fer un programa que vagi demanant números fins trobar el zero i digui si són tots
   parells*/


            int num;
            bool imparell = true;
            Console.WriteLine("num: ");
            num = int.Parse(Console.ReadLine());

            while(num!=0)
            {
                if(num%2!=0)
                    imparell = false;

                num = int.Parse(Console.ReadLine());
            }

            if (imparell==false)
                Console.WriteLine("No son tots parells.");
            else
                Console.WriteLine("Son tots parells.");


        }
    }
}
