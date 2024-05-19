using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.ProblemSolving
{
    public class Result
    {
        public static int SimpleArraySum(List<int> ar)
        {
            int sum = 0;

            foreach (var item in ar)
            {
                sum += item;
            }

            return sum;
        }
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int> { 0, 0 };

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    result[0] += 1;
                else if (a[i] < b[i])
                    result[1] += 1;
            }
            return result;
        }
        public static long AVeryBigSum(List<long> ar)
        {
            long sum = 0;

            foreach (long i in ar)
            {
                sum += i;
            }
            return sum;
        }

        public static int DiagonalDifference(List<List<int>> arr)
        {
            /* {
                 { 1, 2, 3, 4},
                 { 2, 4, 6, 8},
                 { 7, 8, 9, 10 },
                 { 9, 10, 11, 12 }
             }*/

            int firstDioganal = 0;
            int secondDioganal = 0;

            int diff;

            for (int i = 0; i < arr.Count; i++)
            {
                firstDioganal += arr[i][i];
                secondDioganal += arr[i][arr.Count - 1 - i];
            }

            diff = Math.Abs(firstDioganal - secondDioganal);

            return diff;
        }

        public static void PlusMinus(List<int> arr)
        {
            decimal positives = 0;
            decimal negatives = 0;
            decimal zeros = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                    positives += 1;
                else if (arr[i] < 0)
                    negatives += 1;
                else zeros += 1;
            }

            decimal positiveFrac = positives / arr.Count;
            decimal negativeFrac = negatives / arr.Count;
            decimal zerosFrac = zeros / arr.Count;

            Console.WriteLine($"{positiveFrac:F6} \n{negativeFrac:F6} \n{zerosFrac:F6}");
        }

        public static void StairCase(int n)
        {
            /*
             . . . #
             . . # #
             . # # #
             # # # #
             */

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('#', i));
            }
        }

        public static void MiniMaxSum(List<int> arr)
        {
            long minValue = arr[0];
            long maxValue = arr[0];

            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }

                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }

            long totalSum = 0;
            foreach (var number in arr)
            {
                totalSum += number;
            }

            long minSum = totalSum - maxValue;
            long maxSum = totalSum - minValue;

            Console.WriteLine($"{minSum} {maxSum}");
        }
        public static int BirthdayCakeCandles(List<int> candles)
        {
            int counter = 0;

            int maxValue = candles[0];

            for (int i = 1; i < candles.Count; i++)
            {
                if (candles[i] > maxValue)
                {
                    maxValue = candles[i];
                }
            }

            foreach (var candle in candles)
            {
                if (candle == maxValue)
                    counter++;
            }

            return counter;
        }
    }
}
