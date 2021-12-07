using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace adventofcode2021day3_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = File.ReadAllLines(@"C:\Users\Skikk\Documents\adventofcode3.txt");
                    List<string> newList = numbers.OfType<string>().ToList();
            
                    while (newList.Count != 1)
                    {
                        for (int x = 0; x < numbers[0].Length; x++)
                        {
                            newList = PopOxygen(newList, x);
                        }
                    }
                    var oxygenDec = Convert.ToInt64(newList[0], 2);
                    
                    newList = numbers.OfType<string>().ToList();
                    while (newList.Count != 1)
                    {
                        for (int x = 0; x < numbers[0].Length; x++)
                        {
                            newList = PopCo2(newList, x);
                            if (newList.Count == 1) break;
                        }
                    }
                    var o2Dec = Convert.ToInt64(newList[0], 2);
                    
                    Console.WriteLine(oxygenDec * o2Dec);
                }
            
                static List<string> PopOxygen(List<string> lines, int bit)
                {
                  
                    var mostCommon = '0';
                    var countone = lines.Count(line => line[bit] == '1');
                    var countzero = lines.Count - countone;
                    
                    if (countone > countzero) mostCommon = '1';
                    
                    if (countone == countzero) mostCommon = '1';
                    
                    return lines.Where(line => line[bit] == mostCommon).ToList();
                }
            
                static List<string> PopCo2(List<string> lines, int bit)
                {
                    var leastCommon = '0';
                    var oneCount = lines.Count(line => line[bit] == '1');
                    var zeroCount = lines.Count - oneCount;
                    
                    if (oneCount < zeroCount) leastCommon = '1';
                    if (oneCount == zeroCount) leastCommon = '0';
            
                    return lines.Where(line => line[bit] == leastCommon).ToList();
                }
                }
            }
