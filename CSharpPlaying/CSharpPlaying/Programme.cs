extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public class Asset
    {
        public string Name { get; set; }
    }

    public class Stock:Asset
    {
        public int NumberOfShares { get; set; }
    }

    public class House:Asset
    {
        public decimal MortgageAmount { get; set; }
    }

    public class Programme
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock() { Name = "msft", NumberOfShares = 10 };
            House hut = new House() { Name = "Hut", MortgageAmount = 40.9M };
            Display(stock);
            Display(hut);
        }
        static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }
    }
}
