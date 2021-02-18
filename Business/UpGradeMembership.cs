using OrderProcessing.Interfaces;
using System;

namespace OrderProcessing.Business
{
    /// <summary>
    /// Upgrading the membership
    /// </summary>
    public class UpGradeMembership : IMemberShip
    {
        public void ProcessMembership()
        {
            Console.WriteLine("Upgrading membership");
        }
    }
}
