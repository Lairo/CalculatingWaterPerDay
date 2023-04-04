using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingWaterPerDay
{
    internal class Program
    {
        public static string tonnage;
        public static int choiseOfMetric;
        public static bool choiceMade = true;
        static void Main()
        {           
            
            Calculating.ClassicRuleInfo();
            Console.WriteLine($"Would you like to make the calculation:\n1.Kilograms (metric) \n2.Pounds (Imperial)\n");

            //choiseOfMetric = Char.ToUpper(Console.ReadKey().KeyChar);
            choiseOfMetric = Char.ToUpper(Console.ReadKey().KeyChar);

            while (choiseOfMetric != '1' || choiseOfMetric != '2' || choiseOfMetric != '3')
            {
                if (!choiceMade)
                {
                    switch (choiseOfMetric)
                    {
                        case '1': //Kilo
                            choiceMade = false;
                            //Console.Clear();
                            Imperial(choiseOfMetric);
                            break;
                        case '2': //lbs
                            choiceMade = false;
                            //Console.Clear();
                            Imperial(choiseOfMetric);
                            break;
                        case '3': //lbs
                            choiceMade = false;
                            //Console.Clear();
                            Imperial(choiseOfMetric);
                            break;
                        default:
                            Console.WriteLine("\nPlease enter a valid number.");
                            break;
                    }
                   // break;
                   
                }
                else
                //{ while (choiseOfMetric != '1' || choiseOfMetric != '2') 
                    { 
                        switch (choiseOfMetric)
                        {
                            case '1': //Kilo
                                      //Console.Clear();
                                choiceMade = false;
                                Imperial(choiseOfMetric);
                                break;
                            case '2': //lbs
                                      //Console.Clear();
                                choiceMade = false;
                                Imperial(choiseOfMetric);
                                break;                       
                        default:
                            Console.WriteLine("\nPlease enter a valid number.");
                            break;

                    }
                        //break;
                    //}                    
                }
               // break;
            }
            // switch 
            // metric
            // or
            // imperial

                Console.WriteLine("Would you like to convert the number to alternative system?\n (Y or N)");

                // switch 
                // convert and bye
                // or just bye
            
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
                    Console.WriteLine(Calculating.CalculatingWeight(amount, choiseOfMetric));
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
    }
}
