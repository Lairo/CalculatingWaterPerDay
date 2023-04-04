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



    internal class Program
    {
        public static string tonnage = "";
        public static int choiseOfMetric;
        public static bool choiceMade = true;
        public static double tonnageNew;
        static void Main()
        {           
            
            Calculating.ClassicRuleInfo();
            

            //choiseOfMetric = Char.ToUpper(Console.ReadKey().KeyChar);
            //choiseOfMetric = Char.ToUpper(Console.ReadKey().KeyChar);

            while (choiseOfMetric != '1' || choiseOfMetric != '2' || choiseOfMetric != '3')
            {
                Console.WriteLine($"Would you like to make the calculation:\n1.Kilograms (metric) \n2.Pounds (Imperial)\n3.Translate Imperial <> Metric\n4.Exit\n");
                choiseOfMetric = Char.ToUpper(Console.ReadKey().KeyChar);
                switch (choiseOfMetric)
                {
                    case '1': //Kilo
                        Imperial(choiseOfMetric);
                        break;
                    case '2': //lbs
                        Imperial(choiseOfMetric);
                        break;
                    case '3': //lbs
                        Calculating.Converting(tonnageNew, choiseOfMetric);
                        Console.WriteLine("\n");
                        break;
                    case '4': //Exit
                        Console.WriteLine("\nBye \n");
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
        public static void Imperial(int choiseOfMetric)
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
                    Console.WriteLine(Calculating.CalculatingWeight(amount, choiseOfMetric));                    
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
