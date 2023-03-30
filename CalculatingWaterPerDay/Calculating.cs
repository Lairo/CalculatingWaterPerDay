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

        public static void Convertng(double amount, int choice) {

            double newWeight;

            if (choice == '1')
            {
                newWeight = amount * 0.453592;
                CalculatingWeight(newWeight, 2);
            }
            else
            {
                newWeight = amount / 0.453592;
                CalculatingWeight(newWeight, 1);
            } 
        }

        public static string CalculatingWeight(double amount, int choice)
        {
            double cupCapacity = 236.5882;
            double ounce = 0.02835;
            string denomination;

            if (choice == '1')
            {
               denomination = "lbs";
            }
            else
            {
                denomination = "kg";
            }
            // TODO string answer calc
            
            double result = amount / 2;

            double cup = ((result * ounce) / cupCapacity * 1000);
            double litres = result * 0.02835;

            string answer = $"\nThe recommended amount for person with the body weight of {amount}{denomination} , is {litres}l or {Decimal.Round((decimal)cup)}cups.";

            return answer;
        }

        public static void ClassicRuleInfo()
        {
            Console.WriteLine("Classic Rule is 0.5oz/1lbs of body weight.\n");
        }

    }
}
