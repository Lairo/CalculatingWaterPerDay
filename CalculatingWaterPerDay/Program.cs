using System;

namespace CalculatingWaterPerDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Calculating.ClassicRuleInfo();
            Console.WriteLine($"Would you like to make the calculation:\n1.Kilograms (metric) \n2.Pounds (imperial)\n");
            
                choice = Char.ToUpper(Console.ReadKey().KeyChar);
                //int num = int.TryParse(choice, out int bob);
                switch (choice)
                {
                    case '1':
                        break;
                    case '2':
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("\n u stuped");
                        return;
                }
            
                // switch 
                // metric
                // or
                // imperial

                Console.WriteLine("Hello.\nHow much do you weigh?\n");

                //Calculation

                Console.WriteLine("Would you like to convert the number to alternative system?\n (Y or N)");

                // switch 
                // convert and bye
                // or just bye
            
        }
    }
}
