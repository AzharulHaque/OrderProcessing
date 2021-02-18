using OrderProcessing.Interfaces;
using System;

namespace OrderProcessing.Business
{
    /// <summary>
    /// Activatig the membership
    /// </summary>
    public class ActivateMembership : IMemberShip
    {
        /// <summary>
        /// Processing the membership activation
        /// </summary>
        public void ProcessMembership()
        {
            Console.WriteLine("Activating membership");
        }
    }
}
