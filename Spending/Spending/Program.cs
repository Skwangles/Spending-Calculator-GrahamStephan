using System;

namespace Spending
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your annual income, minus tax (Only numbers and decimals): ");

            bool _ = double.TryParse(Console.ReadLine(), out var totalincome);

            while (_ == true)
                {
                Run();
                Console.WriteLine("To exit, Type X and then Enter");
                Console.Write("Your annual income, minus tax (Only numbers and decimals): ");

                _ = double.TryParse(Console.ReadLine(), out totalincome);
            }
            void Run()
            {
                string[,] Operations = new string[7, 3]
                {
            { "Housing:             ", "0.2", "          As little as possible, 25% max" },
            { "Transportation:      ", "0.1" , "         Buy price 25%<"},
            { "Food:                ", "0.1", "          or $600/m,  Which ever is less. " },
            { "Health Insurance:    ", "0.05", "         ~$200-$500" },
            { "Utilities:           ", "0.03", "        $500 or Less" },
            { "Wants:               ", "0.1" , "         Be reasonable"},
            { "Savings:             ", "0.42", "        First save up a 6 month safety fund." } };
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine(Calculate(Operations[i, 0], double.Parse(Operations[i, 1]), Operations[i, 2]));
                }
                
                Console.WriteLine("");
                
            }

            string Calculate(string first, double percentage, string end)
            {
                double temp = totalincome * percentage;

                string line = first + "$" + temp.ToString() + end;
                return line;
            }
        }
    }
}
