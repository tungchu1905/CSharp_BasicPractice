using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExInterface
{
    class Payment : ITax
    {
        // khai bao 1 delegate: Ham con tro tham chieu cho event
        public delegate void Notify(float oldValue, float newValue);
        // khai bao 1 event
        public event Notify AmountChanged;
        //public event EventHandler AmountChanged;
        // 
        public float amount;

        public float Amount { get { return amount; }
            set 
            {
                if (value!= amount) {
                    if (AmountChanged != null) // khi event duoc goi
                        AmountChanged(amount, value); // thuc hien
                    amount = value;
                } 
            } 
        }

        //public float Amounts;

        public float ComputeTax()
        {
            //OnProcessCompleted(EventArgs.Empty); //No event data
             
            return (amount * 10) / 100;
        }
        //protected virtual void OnProcessCompleted(EventArgs e)
        //{
        //    Console.Write("Amount changed – old value: {0}", Amount);
        //    if (Amount != Amounts)
        //    {
        //        Amount = Amounts;
        //    }
            
        //    AmountChanged?.Invoke(this.Amounts, e);
        //}

    }
}
