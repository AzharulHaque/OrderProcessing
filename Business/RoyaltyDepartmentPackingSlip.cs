using OrderProcessing.Interfaces;
using System;

namespace OrderProcessing.Business
{
    /// <summary>
    /// Handling the royalty department packing slip
    /// </summary>
    public class RoyaltyDepartmentPackingSlip : IPackingSlip
    {
        public void GeneratePackingSlip()
        {
            Console.WriteLine("Generating Paking slip for royalty department");
        }
    }
}
