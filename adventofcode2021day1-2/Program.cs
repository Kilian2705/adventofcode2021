using System;
using System.IO;
using System.Linq;


namespace adventofcode2021day1_2
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

            int count2 = 0;

            int a = 0;
            foreach (int number in numbers)
            {
                if(a+3 < numbers.Length)
                {
                    int groupa = numbers[a] + numbers[a + 1] + numbers[a + 2];
                    int groupb = numbers[a + 1] + numbers[a + 2] + numbers[a + 3];
                    if (groupa < groupb)
                    {
                        count2++;
                    }
                    a++;
                }

            }
            Console.WriteLine(count);
            Console.WriteLine(count2);
        }
    }
}