using System;

namespace percentagecalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maximum;
            int UserScore;
            double Results;

            Console.WriteLine("what is the maximum score");
            Maximum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("what is your score?");
            UserScore = Int32.Parse(Console.ReadLine());
            Results = (UserScore * 100) / Maximum;


            Console.WriteLine($"you scored {Results}%.");

            Console.WriteLine($"You scored {Results}%.");
            if (Results >= 90)
            {
                Console.WriteLine("your grade is 5");
            }
            else if (Results >= 80)
            {
                Console.WriteLine("your grade is 4");
            }
            else if (Results >= 61)



            {
                Console.WriteLine("your grade is 3");
            }
            else
            {
                Console.WriteLine("your grade is 2");





            }
        }
    }
} 
