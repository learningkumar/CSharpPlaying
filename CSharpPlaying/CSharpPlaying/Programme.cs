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

    //As per windows standard one needs to define a subclass of eventargs class as a way of passing event info
    public class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal oldPrice;
        public readonly decimal newPrice;
        public PriceChangedEventArgs(decimal oldPrice, decimal newPrice)
        {
            this.oldPrice = oldPrice;
            this.newPrice = newPrice;
        }
    }

    //Windows standard way of writing event 
    public class Equity
    {
        string _symbol;
        decimal _price;
        public Equity(string symbol)
        {
            _symbol = symbol;
        }
        public event EventHandler<PriceChangedEventArgs> PriceChanged;
        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (Price == value)
                    return;
                decimal oldPrice = _price;
                _price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, _price));
            }
        }
    }
    public class Programme
    {
        static void Main(string[] args)
        {
            //With Custom delegate/Event
            Stock stock = new Stock("INFY");
            stock.PriceChanged += DisplayPrice;

            stock.Price = 10;

            //With windows standard way of writing event
            Equity equity = new Equity("TCS");
            equity.PriceChanged += DisplayPrice;
            equity.Price = 90;
        }
        static void DisplayPrice(decimal oldPrice, decimal newPrice)
        {
            Console.WriteLine($"Old price is  : {oldPrice} \n New Price is : {newPrice}");
        }
        static void DisplayPrice(object o, PriceChangedEventArgs e)
        {
            Console.WriteLine($"Old price is  : {e.oldPrice} \n New Price is : {e.newPrice}");
        }
    }
}
