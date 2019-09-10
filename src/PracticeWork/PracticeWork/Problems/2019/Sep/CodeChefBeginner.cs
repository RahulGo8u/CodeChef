using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork.Problems._2019.Sep
{
    public class CodeChefBeginner
    {
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
    }
}
