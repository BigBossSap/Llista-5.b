using System;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Fer un programa que demani una llista de números positius acabada en ‐1 i digui si
   el primer es repeteix. */

            int num,comparador=int.MinValue;
            bool semafor = true;

            Console.WriteLine("num");
            num=Convert.ToInt32(Console.ReadLine());


            while (num!=-1)
            {

                

                if (num==comparador)
                    semafor = false;

                comparador = num;

                num = Convert.ToInt32(Console.ReadLine());
            }

            if (semafor)
                Console.WriteLine("no");
            else
                Console.WriteLine("si");





        }
    }
}
