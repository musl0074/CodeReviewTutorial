using System;

namespace CleanCoding
{
    class Program
    {
       /*  If you want to, you can try to tidy up the code in this repository. There are plenty of things that can be done!
        *  The code itself is not the primary goal of this exercise however.
        *  The actual goal is working with GIT in a way that supports code review. 
        *  
        *  
        *  You could assign half of your team to be coders trying to fix this code
        *  The other half could be reviewers, looking through your code when you submit a pull request. 
        * */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the calculator!");
            Console.WriteLine("Calculate down payment: press 1");
            Console.WriteLine("Calculate approximate loan amount: press 2");
            calculate(Console.ReadLine());
        }

        public static void calculate(string t)
        {
            if(t == "1")
            {
                double hp, pn;
                Console.WriteLine("Price of house? " );
                hp = Double.Parse(Console.ReadLine());
                Console.WriteLine("How many % of the total house price do you need upfront?" );
                pn = Double.Parse(Console.ReadLine());          
                double a = (hp / 100) * pn;
                Console.WriteLine(a + " amount you need");

            }
            else if (t == "2")
            {
                double abe, kat;
                string johannes;
                double monthsInYear, approximateMultiplier;
                Console.WriteLine("Monthly income? : " );
                monthsInYear = Double.Parse(Console.ReadLine());
                Console.WriteLine("Approximate multiplier ? ");
                approximateMultiplier = Double.Parse(Console.ReadLine());      
                double year = monthsInYear * 12;
                double hpa = year * approximateMultiplier;
                Console.WriteLine(hpa + " approximate purchase");
            }
            Console.ReadLine();
        }
    }
}
