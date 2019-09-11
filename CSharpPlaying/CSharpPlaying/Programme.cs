extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public abstract class Asset
    {
        public string Name { get; set; }
        public virtual decimal Liability => 0;

        public abstract decimal NetValue { get; }
    }

    public class Stock : Asset
    {
        public new string Name { get; set; }
        public decimal CurrentPrice;
        public int NumberOfShares { get; set; }
        public override decimal NetValue => CurrentPrice * NumberOfShares;

    }

    public class House : Asset
    {
        public decimal CurrentPrice;
        public decimal MortgageAmount { get; set; }
        public override decimal Liability => MortgageAmount;

        public override decimal NetValue => CurrentPrice;

    }

    public class Programme
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock() { Name = "msft", NumberOfShares = 10, CurrentPrice = 100 };
            House hut = new House() { Name = "Hut", MortgageAmount = 40.9M, CurrentPrice = 200 };

            Display(stock);
            //Display(hut);
        }
        static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }
    }
}
