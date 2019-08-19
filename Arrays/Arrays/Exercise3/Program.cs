using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace Exercise3
{
    class Program
    {
        //TODO: Write a C# program to calculate the average value of array elements.
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};
            var sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                
                sum += numbers[i];
                
                
            }
            
            Console.WriteLine(sum);
            Console.WriteLine(Convert.ToString((Decimal)sum / numbers.Length));
            Console.ReadKey();

            



    }
    }
}
