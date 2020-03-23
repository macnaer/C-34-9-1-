using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Generic.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Wallet<string, int> ltc1 = new Wallet<string, int>("0094TR2W", 100, "LTC");
            Wallet<string, int> ltc2 = new Wallet<string, int>("54ER43Q6", 50, "LTC");
            //ltc1.ShowBalance();
            //ltc1.Pay(90);
            //ltc1.ShowBalance();

            var btc = new Wallet<int, double>(45675444, 1.1222, "BTC");
            btc.ShowBalance();
            btc.Pay(0.21);
            btc.ShowBalance();
            //1.123456789

            var pServiceLTC = new PaymentService<Wallet<string, int>, string>();
            pServiceLTC.FromWallet = ltc1;
            pServiceLTC.ToWallet = ltc2;
            pServiceLTC.Transaction = "34REN95P";
            pServiceLTC.Sum = 20;
            pServiceLTC.MakePayment();

        }
    }
}
