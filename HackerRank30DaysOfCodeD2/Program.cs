using System;

namespace HackerRank30DaysOfCodeD2
{
    class Program
    {
        class Result
        {
            /*
             * Complete the 'solve' function below. Aşağıdaki 'solve' fonksiyonunu tamamlayın.
             *
             * The function accepts following parameters: Şu Parametleri Kullanın.
             *  1. DOUBLE meal_cost
             *  2. INTEGER tip_percent
             *  3. INTEGER tax_percent
             */
            public static void solve(double meal_cost, int tip_percent, int tax_percent)
            {
                double tipCost = meal_cost * tip_percent / 100;
                double taxCost = meal_cost * tax_percent / 100;
                double totalCost = meal_cost + tipCost + taxCost;

                Console.WriteLine(Math.Round(totalCost));
            }

            static void Main(string[] args)
            {
                double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

                int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

                int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

                Result.solve(meal_cost, tip_percent, tax_percent);
            }
        }
    }
}