using OrderProcessing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Business
{
    /// <summary>
    /// Handling the physical prduct payment
    /// </summary>
    public class PhysicalProductPayment : IPayment
    {
        public bool ProcessPayment()
        {
            Console.WriteLine("Processing payment for physical product");
            return true;
        }
    }
}
