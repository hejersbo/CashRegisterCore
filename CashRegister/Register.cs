using System;
using System.Collections.Generic;
using System.Text;

namespace CashRegister
{
    public class Register
    {
        public int NoOfItems { get; set; }
        private double _total;
        private readonly List<double> itemList;
        private string _name;
        public Register()
        {
            _total = 0.0;
            NoOfItems = 0;
           itemList = new List<double>(10);
        }

        public string GetName()
        {
            return _name;
        }

        static int Collatz(int n)
        {
            while (n > 1)
            {
                if (n % 2 == 0) // if n is even, divide it by two
                    n = n / 2;
                else // if n is odd, multiply by three and add one
                    n = 3 * n + 1;
            }

            //while (true)
            //{
            //}

            // unreachable code???
            return n;
        }

        public void AddItem(double itemPrice)
        {
            if (
                itemPrice < 0
                ||
                itemPrice > 10000
                )
                throw new ArgumentOutOfRangeException(nameof(itemPrice), "Prisen er ukorrekt");

            _total += itemPrice;
            NoOfItems++;
            itemList.Add(itemPrice);
        }

        public double GetTotal()
        {
            return _total;
        }

        public int GetNoOfItems()
        {
            return NoOfItems;
        }

        public void SubtractItem(double itemPrice)
        {
            if (itemPrice < 0)
                itemPrice = -itemPrice;

            if (NoOfItems > 0)
            {
                NoOfItems--;
                _total -= itemPrice;
            }

            return;
        }
    }
}
