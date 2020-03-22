using System;
using System.Collections.Generic;
using System.Threading;

namespace Lab1
{
    public class Program
    {
        static long[] c = new long[100];
        static void Main(string[] args)
        {
            List<String> threadInfo = new List<string>();
            Console.WriteLine("Enter a number: ");
            String value = Console.ReadLine();
            Thread t = new Thread(new ThreadStart());
           
        }

        
       public static bool IsPrimeNumber(int number) 
        {
            if (number < 2)
                return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public static int PrimeNumberV1(int value)
        {
            int nr = 0;
            for(int index = value; index >= 2; index--)
            {
                if(IsPrimeNumber(index))
                {
                    nr = index;
                    break;
                }
            }
            return nr;
        }

        static void coef(int n)
        {
            c[0] = 1;

            for (int i = 0; i < n; c[0] = -c[0], i++)
            {
                c[1 + i] = 1;

                for (int j = i; j > 0; j--)
                    c[j] = c[j - 1] - c[j];
            }
        }

        public static bool isPrime(int n)
        {
            coef(n);
            c[0]++;
            c[n]--;
            int i = n;
            while ((i--) > 0 && c[i] % n == 0)
                ;
            return i < 0;
        }

        public static int PrimeNumberV2(int value)
        {
            int nr = 0;
            for (int index = value; index >= 2; index--)
            {
                if (isPrime(index))
                {
                    nr = index;
                    break;
                }
            }
            return nr;
        }

    }
}
