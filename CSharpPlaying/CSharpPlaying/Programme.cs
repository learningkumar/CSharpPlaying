extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

    public class Stock
    {
        string _symbol;
        decimal _price;
        public Stock(string Symbol)
        {
            _symbol = Symbol;
        }
        public event PriceChangedHandler PriceChanged;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price == value)
                    return;
                decimal oldPrice = _price;
                _price = value;
                if (PriceChanged != null)
                    PriceChanged(oldPrice, _price);
            }
        }


    }
    public class Programme
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("INFY");
            stock.PriceChanged += DisplayPrice;
            stock.Price = 10;
        }
        static void DisplayPrice(decimal oldPrice , decimal newPrice)
        {
            Console.WriteLine($"Old price is  : {oldPrice} \n New Price is : {newPrice}");
        }
    }
}
