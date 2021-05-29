using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = new Payment() { amount = 1000 };
            payment.AmountChanged += notifyAmountChanged; // your handling function
            payment.Amount = 990;

            Console.WriteLine("Tax: " + payment.ComputeTax());
        }
        public static void notifyAmountChanged(float oldValue, float newValue)
        {
            Payment pay = new Payment();
            Console.WriteLine("Amount changed – old value: {0} new value : {1}", oldValue, newValue);

        }
    }
}
