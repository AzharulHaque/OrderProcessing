
using OrderProcessing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Business
{
    /// <summary>
    /// Handling the membership upgrade payment
    /// </summary>
    public class MembershipUpgradePayment : IPayment

    {
        public bool ProcessPayment()
        {
            Console.WriteLine("Processing payment for membership upgrade");
            return true;
        }
    }
}
