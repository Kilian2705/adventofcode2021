using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace adventofcode2021day2_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = File.ReadAllLines(@"C:\Users\Skikk\Documents\adventofcode2.txt").Select(o =>o.Split(' '));

            string direction = "";
            int i = 0;
            int x = 0;
            int y = 0;
            int aim = 0;
            foreach (var line in numbers)
            {
                direction = line[0];
                i = int.Parse(line[1]);
                if (direction == "down")
                {
                    aim -= i;
                }
                
                if (direction == "up")
                {
                    aim += i;
                }
                
                if (direction == "forward")
                {
                    x += i;
                    y += i * aim;
                }
            }
            Console.WriteLine(x * y);
        }
    }
}