﻿using System;

namespace Power2Method
{
    class Program
    {
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();

        }


        private static void PowersOf2Until5()
        {
            for (int i = 1; i <= (i << 5); i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}