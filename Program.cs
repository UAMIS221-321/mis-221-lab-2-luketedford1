using System;

namespace Lab2
{
    class Program
    {
        static void Main()
        {
            const double costOfSandwich = 4.75 ;
            const double costOfToppings = 0.55 ;
            const double discountAmount = 0.9 ;
            string numSandwiches;
            string numToppings;
            string numTip;
            double numberOfSandwiches;
            double numberOfToppings;
            double totalSandwichCost;
            double totalToppingsCost;
            double baseCost;
            double tip;
            double orderCost;
            

            Console.WriteLine("Welcome to Sherlynthia's Sandwich Shop! How many sandwiches would you like?");
            numSandwiches = Console.ReadLine();
            numberOfSandwiches = double.Parse(numSandwiches);
             
            Console.WriteLine("How many toppings would you like?");
            numToppings = Console.ReadLine();
            numberOfToppings = double.Parse(numToppings);

            Console.WriteLine("How much would you like to tip?");
            numTip = Console.ReadLine();
            tip = double.Parse(numTip);

            totalSandwichCost = numberOfSandwiches * costOfSandwich;
            totalToppingsCost = numberOfToppings * costOfToppings;
            baseCost = totalSandwichCost + totalToppingsCost;

            orderCost = tip + baseCost * discountAmount;

            Console.WriteLine("Your total is $" + orderCost);



        }
    }
}
