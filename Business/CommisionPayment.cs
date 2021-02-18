using OrderProcessing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Business
{
    /// <summary>
    /// Payment for the commission
    /// </summary>
    public class CommisionPayment : IPayment
    {
        public bool ProcessPayment()
        {
            Console.WriteLine("Procssing commission payment");
            return true;
        }
    }
}
