using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user input for exam score
            Console.Write("Enter your exam score as a percentage: ");
            double score = Convert.ToDouble(Console.ReadLine());

            // Determine and display letter grade
            if (score >= 90)
            {
                Console.WriteLine("Your letter grade is A.");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Your letter grade is B.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Your letter grade is C.");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Your letter grade is D.");
            }
            else
            {
                Console.WriteLine("Your letter grade is F. Better luck next time!");
            }
            Console.ReadKey();
        }
    }
}
    

