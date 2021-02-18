using OrderProcessing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Business
{
    /// <summary>
    /// Processing the payment for books
    /// </summary>
    public class BookPayment : IPayment
    {
        /// <summary>
        /// Making the books payment
        /// </summary>
        /// <returns></returns>
        public bool ProcessPayment()
        {
            Console.WriteLine("Processing payment for books");
            return true;
        }
    }
}
