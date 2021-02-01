using System;
using System.Collections.Generic;
using System.Text;

namespace CashRegister
{
    public class Register
    {
        public int NoOfItems { get; set; }
        private double _total;
        public Register()
        {
            _total = 0.0;
            NoOfItems = 0;
        }

        public void AddItem(double itemPrice)
        {
            if (itemPrice < 0)
                throw new ArgumentOutOfRangeException("Prisen er mindre end nul");

            _total += itemPrice;
            NoOfItems++;
        }

        public double GetTotal()
        {
            return _total;
        }

        public int GetNoOfItems()
        {
            return NoOfItems;
        }

    }
}
