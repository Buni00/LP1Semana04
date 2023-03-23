﻿using System;

namespace Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o número da sequência que deseja saber: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Lucas(valor));
        }

        private static int Lucas (int n)
        {
            int numero;

            if (n == 0)
            {
                numero = 2;
            }
            else if (n == 1)
            {
                numero = 1;
            }

            else
            {
                numero = Lucas (n - 1) + Lucas (n - 2);
            }

            return numero;
        }
        
    }
}
