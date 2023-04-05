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

        public static void Converting(double ConversionAmount, int initialChoice)
        {
            double newWeight;

            if (initialChoice == 1)
            {
                // Converting to lbs
                newWeight = ConversionAmount * 2.2;
                Console.WriteLine(Calculating.CalculatingWeight(newWeight, 2));
            }
            else
            {
                //Converting to KG
                newWeight = ConversionAmount / 2.2;
                Console.WriteLine(Calculating.CalculatingWeight(newWeight, 1));
            }
        }

        public static string CalculatingWeight(double amount, int choice)
        {
            double cupCapacityInMilliliters = 236.5882;
            double ounceInKiloGrams = 0.02835;
            string denomination;
            string recommendedAmmount;

            // 0.5oz per body weight; ergo result
            double result = amount / 2;

            double cup = ((result * ounceInKiloGrams) / cupCapacityInMilliliters * 1000);

            //converting to liters from ounces
            double liters = result * ounceInKiloGrams;

            if (choice == 1)
            {
                denomination = "KG";
                recommendedAmmount = $" is {liters:0.00}L water a day,\n\t\twhich adds up to {Decimal.Round((decimal)cup*2)} cups, per day.";
            }
            else
            {
                denomination = "lbs";
                recommendedAmmount = $" is {result:0}oz of water a day,\n\t\twhich adds up to {Decimal.Round((decimal)cup)} cups, per day.";
            }

            // TODO string answer calc
            string answer = $"\nThe recommended amount for person with the body weight of {Decimal.Round((decimal)amount)}{denomination}" + recommendedAmmount + "\n";

            return answer;
        }

        public static void ClassicRuleInfo()
        {
            Console.WriteLine("Classic Rule is 0.5oz/1lbs of body weight.\n");
        }

    }
}
