using System;

namespace Power2Method
{
    class Program
    {
        /// <summary>
        /// Prints Powers of 2 until 5 two times and then Powers of 2 until 2 and 3
        /// </summary>
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();

            PowersOf2UntilN(2 , 3);
            PowersOf2UntilN(3 , 4);

        }

        /// <summary>
        /// Prints powers of 2 until 5
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
        }


        /// <summary>
        /// prints powers of 2 until n
        /// </summary>
        /// <param name="n"> last power to be printed </param>
        private static void PowersOf2UntilN (int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }

        private static void PowersOf2UntilN (int n1, int n2)
        {
            for (int i = 1 << n1; i <= (1 << n2); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
