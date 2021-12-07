using System;
using System.IO;
using System.Linq;


namespace adventofcode2021day1_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = File.ReadAllLines(@"C:\Users\Skikk\Documents\nummertjesadventofcode1.txt")
                .Select(number => int.Parse(number)).ToArray();

            int count = 0;
            int beginnummer = numbers[0];
            int i = 1;
            int j = 0;

            foreach (int number in numbers)
            {
                if(i < numbers.Length)
                {
                    if (numbers[i] > numbers[j])
                    {
                        count++;
                    }
                    j++;
                    i++;
                }

            }
            Console.WriteLine(count);
        }
    }
}
