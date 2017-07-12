using System;
using System.Collections.Generic;

namespace transactionTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
                transactions.Add(("bowl", 3.50, 6));
                transactions.Add(("spoon", 1.20, 3));
                transactions.Add(("fork", 1.20, 4));
                transactions.Add(("knife", 2.30, 5));
                transactions.Add(("plate", 4.20, 7));

                int totalQuantity = 0;
                double revenue = 0;

            foreach ((string product, double amount, int quantity) transaction in transactions){
                totalQuantity +=transaction.quantity;
                revenue += transaction.amount * totalQuantity; 
            }
            
            // Console.WriteLine($"{product.Item1} {product.Item2} {product.Item3} ");
                Console.WriteLine(totalQuantity);
                Console.WriteLine($"{revenue:C}");

        }
    }
}
