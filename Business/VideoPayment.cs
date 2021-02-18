using OrderProcessing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Business
{
    /// <summary>
    /// Class for making payment for video
    /// </summary>
    public class VideoPayment : IPayment
    {
        /// <summary>
        /// Processing the payment
        /// </summary>
        /// <returns></returns>
        public bool ProcessPayment()
        {
            Console.WriteLine("Processing payment for video");
            return true;
        }
    }
}
