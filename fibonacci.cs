using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{    
    class Program
    {
        private static int n = 80;
        private static long[] fibonacciCache = new long[n + 1];

        static void Main(string[] args)
        {
				     long a = 0, b = 1, c = 0;
            for(int i = 0; i < n; i++){
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine((i+1) + " => " + a);
            }
        		a = 0, b = 1, c = 0;
            for (int i = 0; i < n; i++) {
				    a = fibonacciProgDinamica(i);
            Console.WriteLine((i + 1) + " => " + a);
			}
			      Console.ReadKey();
        }

        static long fibonacciProgDinamica (int n){
            if (n < 0)
            {
                throw new Exception("Number can not be less than zero");
            }
            if (n <= 2)
            {
                fibonacciCache[n] = 1;
            }
            if (fibonacciCache[n] == 0)
            {
                fibonacciCache[n] = fibonacciProgDinamica(n - 1) + fibonacciProgDinamica(n - 2);
            }
            return fibonacciCache[n];
        }
    }
}
