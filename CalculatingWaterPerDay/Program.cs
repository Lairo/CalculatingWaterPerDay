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
        static void Main(string[] args)
        {
            int choice;
            
            Calculating.ClassicRuleInfo();
            Console.WriteLine($"Would you like to make the calculation:\n1.Kilograms (metric) \n2.Pounds (imperial)\n");
            
                choice = Char.ToUpper(Console.ReadKey().KeyChar);
                
                switch (choice)
                {
                    case '1': //Kilo
                        Console.Clear();

                        break;
                    case '2': //lbs
                        Console.Clear();
                        imperial();
                        break;
                    default:
                        Console.WriteLine("\n u stuped");
                        return;
                }

           

            


            // switch 
            // metric
            // or
            // imperial

            Console.WriteLine("\nHello.\nHow much do you weigh?\n");

                //Calculation

                Console.WriteLine("Would you like to convert the number to alternative system?\n (Y or N)");

                // switch 
                // convert and bye
                // or just bye
            
        }
        public static void imperial()
        {            
            while (true)
            {
                Console.WriteLine($"Enter weight");

                tonnage = Console.ReadLine();
                //if(double.TryParse(tonnage, out double amount))

                //lbs
                if (int.TryParse(tonnage, out int amount))
                {
                    Console.WriteLine(Calculating.CalculatingWeight(amount));
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
    }
}
