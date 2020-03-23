using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Generic.Collections
{
    class Wallet<W, B>
    {
        public W WolletNumber { get; private set; } 
        B Balance { get; set; }
        string Currency { get; set; }

        public Wallet(W number, B startBalance, string currency)
        {
            this.WolletNumber = number;
            this.Balance = startBalance;
            this.Currency = currency;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Wallet number: {this.WolletNumber}\nBalance: {this.Balance}\nCurrency: {this.Currency}");
        }

        public void Pay(B amount)
        {
            this.Balance = amount;
        }
    }
}
