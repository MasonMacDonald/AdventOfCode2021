using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aoc.Solutions
{
    public class Day02
    {
        private List<string> initialRead;
        private string[] values;
        private string path = "C:\\dev\\repos\\adventofcode\\aoc\\ConsoleApp1\\Datasets\\input02.txt";
        private int depth;
        private int distance;
        private int aim;

        public Day02()
        {
            initialRead = File.ReadLines(path).ToList();
            values = new string[initialRead.Count];
        }

        public int partOne()
        {
            depth = 0;
            distance = 0;
            aim = 0;

            try
            {
                for (int i = 0; i < initialRead.Count; i++)
                {
                    values = initialRead[i].Split(' ');
                    if (values[0].StartsWith('f'))
                    {
                        distance += int.Parse(values[1]);
                    }
                    else if (values[0].StartsWith('u'))
                    {
                        depth -= int.Parse(values[1]);
                    }
                    else if (values[0].StartsWith('d'))
                    {
                        depth += int.Parse(values[1]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error occured while converting file to integers");
            }
            return depth * distance;
        }

        public int partTwo() 
        {
            depth = 0;
            distance = 0;
            aim = 0;

            try
            {
                for (int i = 0; i < initialRead.Count; i++)
                {
                    values = initialRead[i].Split(' ');
                    if (values[0].StartsWith('f'))
                    {
                        distance += int.Parse(values[1]);
                        depth +=  aim * int.Parse(values[1]);
                    }
                    else if (values[0].StartsWith('u'))
                    {
                        aim -= int.Parse(values[1]);
                    }
                    else if (values[0].StartsWith('d'))
                    {
                        aim += int.Parse(values[1]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error occured while converting file to integers");
            }
            return depth * distance;
        }
    }
}
