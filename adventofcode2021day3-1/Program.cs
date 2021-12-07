using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace adventofcode2021day3_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = File.ReadAllLines(@"C:\Users\Skikk\Documents\adventofcode3.txt");
            var gamma = "";
            var epsilon = "";
            var countgamma = new List<int>()
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            foreach (var number in numbers)
            {
                for (var i = 0; i < number.Length; i++)
                {
                    if (number[i] == '1')
                    {
                        countgamma[i] += 1;
                    }
                }
            }

            foreach (var cg in countgamma)
            {
                if (cg > 500)
                {
                    gamma += "1";
                    epsilon += "0";
                }
                else
                {
                    gamma += "0";
                    epsilon += "1";
                }
            }

            var gd = Convert.ToInt64(gamma, 2);
            var ed = Convert.ToInt64(epsilon, 2);
            Console.WriteLine(gd * ed);
        }
    }
}