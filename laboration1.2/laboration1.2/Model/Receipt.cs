using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laboration1._2
{
    public class Receipt
    {
        private double _subtotal;

        public double DiscountRate
        {
            get;
            private set;
        }

        public double MoneyOff
        {
            get;
            private set;
        }

        public double Total
        {
            get;
            private set;
        }

        public double Subtotal
        {
            get { return _subtotal; }
            private set
            {
                if (value > 0)
                {
                    _subtotal = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        //Metoder

        public void Calculate(double subtotal)
        {
            Subtotal = subtotal;

            if (subtotal > 0 && subtotal < 500) // 0-499
            {
                DiscountRate = 0;
            }

            if (subtotal >= 500 && subtotal < 1000) // 500 - 999
            {
                DiscountRate = 0.05;
            }

            if (subtotal >= 1000 && subtotal < 5000) // 1000 - 4999
            {
                DiscountRate = 0.10;
            }

            if (subtotal >= 5000) // 5000+
            {
                DiscountRate = 0.15;
            }

            double standardPrice = 1;

            double newPrice = (standardPrice - DiscountRate) * subtotal;

            double moneyOff = subtotal - newPrice;

            MoneyOff = moneyOff;

            Total = newPrice;
            
 
        }

        public Receipt()
        {
            this._subtotal = 50;
        }
    }
}