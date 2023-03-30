using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingWaterPerDay
{
    internal class Calculating
    {
        // Math 
        // https://www.youtube.com/shorts/26_RduLTcXk
        //
        // 1oz = 0.02835kg
        // 1cup = 236.5882ml
        // 1lbs = 0.453592kg
        //
        // .5oz/1lbs of body weight
        //


        public static string CalculatingWeight(int amount)
        {
            double cupCapacity = 236.5882;
            double ounce = 0.02835;
            int result = amount / 2;
            double cup = ((result * ounce) / cupCapacity * 1000);

            string answer = $"\nThe recommended amount for person with the body weight of {amount}lbs, is {result}oz or {Decimal.Round((decimal)cup)} ";

            return answer;


        }

        public static void ClassicRuleInfo()
        {
            Console.WriteLine("Classic Rule is 0.5oz/1lbs of body weight.\n");
        }

    }
}
