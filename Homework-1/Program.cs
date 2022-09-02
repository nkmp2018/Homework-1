using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1 {
    enum TransactionType { Buy, Sell }
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Input the nominal of the trade:");
            string userInput = Console.ReadLine();
            int nominal = Int32.Parse(userInput);

            Console.WriteLine("Input the Original price");
            userInput = Console.ReadLine();
            double originalPrice = Double.Parse(userInput) ;

            Console.WriteLine("Input the tradeprice");
            userInput = Console.ReadLine();
            double tradePrice = Double.Parse(userInput);

            TransactionType trcType;
            Console.WriteLine("Input the transaction type");
            userInput = Console.ReadLine();
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            double currentValue = 0.0d;

            currentValue = 
            trcType == TransactionType.Buy ? currentValue = nominal * tradePrice: currentValue = nominal * tradePrice*-1;

            double PL = 0.0d;
             PL= nominal * (tradePrice - originalPrice);


            Console.WriteLine($" The Current Value is:{currentValue}");
            Console.WriteLine($" The PL Value is:{PL}");
            Console.ReadKey();


        }
    }
}
