using System;
using System.Collections.Generic;
using System.IO;

namespace adventofcode2021day7_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> crabyList = new List<int>();
            int m = 0;
            int t = 0;
            int s = 0;
            foreach (string line in File.ReadLines(@"C:\Users\Skikk\Documents\adventofcode7.txt"))
            {
                foreach (string crab in line.Split(','))
                {
                    crabyList.Add(Convert.ToInt32(crab));
                    t += Convert.ToInt32(crab);
                }
            }

            m = (int) Math.Ceiling((double)(t / (crabyList.Count)));
            

            foreach (int crab in crabyList)
            {
                int pos = Math.Abs(crab - m);
                s += (pos * (pos + 1)) / 2;
            } 
            Console.WriteLine(s);
        }
    }
}