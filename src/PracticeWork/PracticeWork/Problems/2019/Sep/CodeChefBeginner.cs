using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork.Problems._2019.Sep
{
    public class CodeChefBeginner
    {
        /*The purpose of this problem is to verify whether the method you are using to 
         * read input data is sufficiently fast to handle problems branded with the enormous Input/Output warning.
         * You are expected to be able to process at least 2.5MB of input data per second at runtime.*/
        public static int InputDivisibleCount()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if ((int.Parse(Console.ReadLine()) % k) == 0)
                {
                    count++;
                }
            }
            return count;
        }

        /*Pooja would like to withdraw X $US from an ATM.
         * The cash machine will only accept the transaction if X is a multiple of 5, 
         * and Pooja's account balance has enough cash to perform the withdrawal transaction (including bank charges). 
         * For each successful withdrawal the bank charges 0.50 $US. Calculate Pooja's account balance after an attempted transaction.*/
        public static double CalculateAccountBalance()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            int withdrawlAmt = int.Parse(input[0]);
            double remainingBalance = double.Parse(input[1]);
            if (withdrawlAmt % 5 == 0 && withdrawlAmt <= (remainingBalance - 0.50))
            {
                return remainingBalance - withdrawlAmt - 0.50;
            }
            else
            {
                return remainingBalance;
            }
        }

        /*Shivam is the youngest programmer in the world, he is just 12 years old. Shivam is learning programming and today he is writing his first program.
           Program is very simple, Given two integers A and B, write a program to add these two numbers.*/
        public static void SumOfNumbers()
        {
            int T = int.Parse(Console.ReadLine());
            List<int> sumLst = new List<int>();
            List<string> input = new List<string>();
            for (int i = 0; i < T; i++)
            {
                input = Console.ReadLine().Split(' ').ToList();
                sumLst.Add(int.Parse(input[0])+ int.Parse(input[1]));
            }
            foreach (var result in sumLst)
            {
                Console.WriteLine(result);
            }
        }

        /*You are asked to calculate factorials of some small positive integers.*/
        public static void CalculateFactorials()
        {
            int t = int.Parse(Console.ReadLine());
            List<BigInteger> factLst = new List<BigInteger>();
            int n = 0;
            BigInteger fact;
            for (int i = 0; i < t; i++)
            {
                fact = 1;
                n = int.Parse(Console.ReadLine());
                if (n > 1)
                {
                    while (n > 0)
                    {
                        fact *= n;
                        n--;
                    }
                }
                factLst.Add(fact);
            }
            foreach (var result in factLst)
            {
                Console.WriteLine(result);
            }
        }

        /*You're given an integer N. Write a program to calculate the sum of all the digits of N.*/
        public static void SumOfDigits()
        {
            int t = int.Parse(Console.ReadLine());            
            List<int> sumLst = new List<int>();
            int sum;
            for (int i = 0; i < t; i++)
            {
                sum = 0;
                var input = Console.ReadLine().ToCharArray();
                foreach (var c in input)
                {
                    sum += int.Parse(c.ToString());
                }
                sumLst.Add(sum);
            }
            foreach (var result in sumLst)
            {
                Console.WriteLine(result);
            }
        }
    }
}
