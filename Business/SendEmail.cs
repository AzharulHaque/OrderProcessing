using OrderProcessing.Interfaces;
using System;

namespace OrderProcessing.Business
{
    /// <summary>
    /// halding the mail sending functionality
    /// </summary>
    public class SendEmail : ISendEMail
    {
        public bool SendMail()
        {
            Console.WriteLine("Sending mail");
            return true;
        }
    }
}
