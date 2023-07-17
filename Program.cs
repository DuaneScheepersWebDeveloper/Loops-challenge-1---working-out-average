namespace AverageScoreCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            double average;

            Console.WriteLine("Enter scores between 0 and 20. Enter -1 to calculate the average.");

            while (true)
            {
                Console.Write("Enter a score: ");
                int score;

                if (!int.TryParse(Console.ReadLine(), out score))
                {
                    Console.WriteLine("Invalid input! Please enter a valid score.");
                    continue;
                }

                if (score == -1)
                    break;

                if (score < 0 || score > 20)
                {
                    Console.WriteLine("Invalid input! Score should be between 0 and 20.");
                    continue;
                }

                sum += score;
                count++;
            }

            if (count == 0)
            {
                Console.WriteLine("No scores entered.");
            }
            else
            {
                average = (double)sum / count;
                Console.WriteLine("Average score: " + average);
            }

            Console.ReadKey();
        }
    }
}
