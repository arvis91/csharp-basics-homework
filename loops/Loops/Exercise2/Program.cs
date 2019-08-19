using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int i = 2;
                var a = i;
            int n;
                int x;

            Console.WriteLine("Input number of terms : ");

            n = Convert.ToInt32(Console.ReadLine());

            for (x=0;x<n; x++)
            {
                
                a *= i;
                Console.WriteLine(a);
            }

            Console.WriteLine(a);
            Console.ReadKey();
            /*for (int count = 0;count<n ; count++)
            {
                Console.WriteLine(n);
                int i = ++i;

            }*/





            /*
            todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            for (.......) {
              Console.WriteLine(........);
            }
            */
        }
    }
}
