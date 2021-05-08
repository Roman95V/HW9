using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW9._2
{
    public class Purse
    {
        public string Currency { get; }
        public double Money { get; set; }

        public Purse(string currency)
        {
            Money = 0;
            Currency = currency;
        }
    }
}
