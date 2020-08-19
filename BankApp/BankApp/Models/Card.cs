using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    public class Card
    {
        public string Number { get; set; }
        public string Holder { get; set; }
        public string Balance { get; set; }
        public string Expires { get; set; }
        public string Cvv { get; set; }

        public Card(string number, string holder, string balance, string expires, string cvv)
        {
            Number = number;
            Holder = holder;
            Balance = "$" + balance;
            Expires = expires;
            Cvv = cvv;
        }
    }
}
