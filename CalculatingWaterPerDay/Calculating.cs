using System;

namespace CalculatingWaterPerDay
{
    internal class Calculating
    {
        //TODO
        // Constructor
        // get;set;
        // 

        public static double cupCapacityInMilliliters = 236.5882;
        public static double ounceInKiloGrams = 0.02835;

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
            if(ConversionAmount == 0)
            {
                Console.Clear();
                Console.WriteLine($"\nChoose option 1. or 2. first as I have nothing to convert.");
                return;
            }
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

        public static string CalculatingWeight(double amount, int choice=0)
        {
            
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
            string answer = $"\nThe recommended amount for person with the body weight of {Decimal.Round((decimal)amount)}{denomination}" + recommendedAmmount + "\n" + "\nWould you like to convert the number to alternative system?\n(Utilize option 3.)\n";

            return answer;
        }

        public static void ClassicRuleInfo()
        {
            Console.WriteLine("Classic Rule is 0.5oz/1lbs of body weight.");
        }

    }
}
