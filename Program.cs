using System;

namespace Day5
{
    internal class Flipcoin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flip Coin Program!");

            int head = 0;
            int tail = 1;
            int n;
            int count = 0;

            Console.WriteLine("Enter no. of times you want to flip the coin");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            { 
            Random random = new Random();
            int check = random.Next(2);

                if (check == 0)
                {
                    Console.WriteLine("It's heads!");
                    count = count + 1;
                    

                }
                else
                {
                    Console.WriteLine("It's Tails!");
                }

                

            }

            double c = count;
            double num = n;

            double hPercent = (c / num) * 100;
            double tPercent = 100 - hPercent;

            Console.WriteLine("Heads Percentage: " +hPercent + " Tails Percentage: " +tPercent);

        } 
        
    }
}
