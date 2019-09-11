using System;
using System.Collections.Generic;

namespace StockPurchaseDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("F", "Ford");
            stocks.Add("IBM", "International Business Machines");
            stocks.Add("FIZZ", "National Beverage Corp.");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GM", shares: 20, price: 30.34));
            purchases.Add((ticker: "GM", shares: 15, price: 3.34));
            purchases.Add((ticker: "CAT", shares: 20, price: 30.55));
            purchases.Add((ticker: "CAT", shares: 20, price: 44.44));
            purchases.Add((ticker: "F", shares: 45, price: 20.65));
            purchases.Add((ticker: "F", shares: 25, price: 1.34));
            purchases.Add((ticker: "IBM", shares: 20, price: 6.66));
            purchases.Add((ticker: "IBM", shares: 20, price: 420.69));
            purchases.Add((ticker: "FIZZ", shares: 20, price: 66.64));
            purchases.Add((ticker: "FIZZ", shares: 200, price: 3.22));


            var totalOwnerShip = new Dictionary<string, double>();
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                var fullCompanyName = stocks[purchase.ticker];
                double priceToAdd = purchase.shares * purchase.price;
                if (totalOwnerShip.ContainsKey(fullCompanyName))
                {
                    totalOwnerShip[fullCompanyName] += priceToAdd;
                }
                else
                {
                    totalOwnerShip.Add(fullCompanyName, priceToAdd);
                }
            }
            foreach(var (company, amount) in totalOwnerShip)
            {
                Console.WriteLine($"You own ${amount} of shares in {company}");
            }
            
        }
    }
}
