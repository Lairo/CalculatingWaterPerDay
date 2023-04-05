using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingWaterPerDay
{

    // TODO
    // Previous calculations in a list/array
    //  -multiple list/array conversion i.e.: a) 80L, 1.1L or 176lbs 11cups
    //                                        b) 80L, 1.1L or 176lbs 11cups
    //  database .csv ?
    // GUI
    // Mobile?


    internal class Program
    {
        public static string tonnage = "";
        public static int choiceOfMetric;
        public static bool choiceMade = true;
        public static double tonnageNew;
        static void Main()
        {      
            Calculating.ClassicRuleInfo();
            
            //choiceOfMetric = Char.ToUpper(Console.ReadKey().KeyChar);
            //choiceOfMetric = Char.ToUpper(Console.ReadKey().KeyChar);

            while (choiceOfMetric != '1' || choiceOfMetric != '2' || choiceOfMetric != '3')
            {
                Console.WriteLine($"Would you like to make the calculation:\n1.Kilograms (metric) \n2.Pounds (Imperial)\n3.Translate Imperial <> Metric\n4.Clear the screen\n0.Exit\n");
                choiceOfMetric = Char.ToUpper(Console.ReadKey().KeyChar);
                switch (choiceOfMetric)
                {
                    case '1': //Kilo
                        Imperial(choiceOfMetric);
                        break;
                    case '2': //lbs
                        Imperial(choiceOfMetric);
                        break;
                    case '3': //lbs
                        Calculating.Converting(tonnageNew, choiceOfMetric);
                        Console.WriteLine("\n");
                        break;
                    case '4': //clear
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
                Console.WriteLine("Would you like to convert the number to alternative system?\n (Y or N)");
        }
        public static void Imperial(int choiceOfMetric)
        {
            while (true)
            {
                Console.Write($"\nEnter weight: ");

                tonnage = Console.ReadLine();
                //if(double.TryParse(tonnage, out double amount))

                //lbs
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
