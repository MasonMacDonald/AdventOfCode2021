using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc
{
    public class Day01
    {
        private List<string> initialRead;
        private int[] numbers;
        private int[] sums;
        private string path = "C:\\dev\\repos\\adventofcode\\aoc\\ConsoleApp1\\Datasets\\input01.txt";

        public Day01()
        {
            initialRead = File.ReadLines(path).ToList();
            numbers = new int[initialRead.Count];

            try
            {
                for (int i = 0; i < initialRead.Count; i++)
                {
                    numbers[i] = int.Parse(initialRead[i]);
                }
            }
            catch 
            {
                Console.WriteLine("Error occured while converting file to integers");
            }
        }

        public int partOne()
        {
            int timesIncreased = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1]) timesIncreased++;
            }
            return timesIncreased;
        }
        
        public int partTwo()
        {
            int timesIncreased = 0;
            sums = new int[numbers.Length];

            int j = 0;
            for (int i = 2; i < numbers.Length; i++)
            {
                sums[j] = numbers[i] + numbers[i-1] + numbers[i-2];
                j++;
            }

            for (int i = 1; i < sums.Length; i++) 
            {
                if (sums[i] > sums[i - 1]) 
                {
                    timesIncreased++;
                }
            }
            return timesIncreased;
        }  
        
        
    }
}
