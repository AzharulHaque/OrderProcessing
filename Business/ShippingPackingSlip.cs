using OrderProcessing.Interfaces;
using System;

namespace OrderProcessing.Business
{
    /// <summary>
    /// Halding the shipping packing slip
    /// </summary>
    public class ShippingPackingSlip : IPackingSlip
    {
        public void GeneratePackingSlip()
        {
            Console.WriteLine("Generating Paking slip for shipping");
        }
    }
}
