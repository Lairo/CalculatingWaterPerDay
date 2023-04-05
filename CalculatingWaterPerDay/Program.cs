using System;

namespace CalculatingWaterPerDay
{

    // TODO
    // 
    // GUI
    // Blazor?
    // Mobile?


    internal class Program
    {
        public static string tonnage = "";
        public static int choiceOfMetric;
        public static bool choiceMade = true;
        public static int initialChoice;
        public static double tonnageNew;
        static void Main()
        {      
            Calculating.ClassicRuleInfo();            

            while (choiceOfMetric != '1' || choiceOfMetric != '2' || choiceOfMetric != '3')
            {
                Console.WriteLine($"\nWould you like to make the calculation:" +
                    $"\n\t1.Kilograms (Metric) " +
                    $"\n\t2.Pounds (Imperial)" +
                    $"\n\t3.Translate Last Calculation Metric <> Imperial" +
                    $"\n\t4.List Previous Choices" +
                    $"\n\t9.Clear the screen" +
                    $"\n\t0.Exit\n");
                choiceOfMetric = Char.ToUpper(Console.ReadKey().KeyChar);
                switch (choiceOfMetric)
                {
                    case '1': //Kilo
                        initialChoice = 1;
                        Imperial(choiceOfMetric);                        
                        break;
                    case '2': //lbs
                        initialChoice = 2;
                        Imperial(choiceOfMetric);                        
                        break;
                    case '3': //lbs
                        Calculating.Converting(tonnageNew, initialChoice);
                        Console.WriteLine("\n");
                        break;
                    case '4': //List Previous Choices
                        //ListingPreviousChoices.
                        Console.WriteLine("\nEmpty.\n");
                        break;
                    case '9': //clear
                        Console.Clear();
                        break;
                    case '0': //Exit
                        Console.WriteLine("\nBye\n");
                        Environment.Exit(0);                        
                        break;
                    default:
                        Console.Clear();
                        Console.Write("\nPlease enter a valid number.\n\n");
                        break;
                }
            }       
                
        }
        public static void Imperial(int choiceOfMetric)
        {
            while (true)
            {
                Console.Write($"\nEnter weight: ");

                tonnage = Console.ReadLine();
                
                if (double.TryParse(tonnage, out double amount))
                {
                    tonnageNew = amount;
                    Console.WriteLine(Calculating.CalculatingWeight(amount, choiceOfMetric));                    
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                return;
            }
        }
    }
}
