using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Generic.Collections
{
    class PaymentService<W, T>
        //where W : class
        where W : Wallet<string, int>
    {
        public W FromWallet { get; set; }
        public W ToWallet { get; set; }
        public int Sum { get; set; }
        public T Transaction {get; set;}

        public void MakePayment()
        {
            Console.WriteLine($"From Wallet {this.FromWallet.WolletNumber}\nTo Wallet {this.ToWallet.WolletNumber}\nTransaction {this.Transaction}\nSum {this.Sum}");
        }
    }
}
