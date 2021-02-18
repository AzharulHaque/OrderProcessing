using OrderProcessing.Interfaces;
using System;

namespace OrderProcessing.Business
{
    public class ProcessOrder : IProcessOrder
    {
        private readonly RoyaltyDepartmentPackingSlip royaltyDepartmentPackingSlip;
        private readonly BookPayment bookPayment;
        private readonly CommisionPayment commisionPayment;
        private readonly ActivateMembership activateMembership;
        private readonly UpGradeMembership upGradeMembership;
        private readonly PhysicalProductPayment physicalProductPayment;
        private readonly MembershipActivatePayment membershipActivatePayment;
        private readonly MembershipUpgradePayment membershipUpgradePayment;
        private readonly SendEmail sendEmail;
        private readonly VideoPayment videoPayment;

        /// <summary>
        /// Processing the main order for different types of product
        /// </summary>
        /// <param name="_royaltyDepartmentPackingSlip"></param>
        /// <param name="_bookPayment"></param>
        /// <param name="_commisionPayment"></param>
        /// <param name="_activateMembership"></param>
        /// <param name="_upGradeMembership"></param>
        /// <param name="_physicalProductPayment"></param>
        /// <param name="_membershipActivatePayment"></param>
        /// <param name="_membershipUpgradePayment"></param>
        /// <param name="_sendEMail"></param>
        /// <param name="_videoPayment"></param>
        public ProcessOrder(RoyaltyDepartmentPackingSlip _royaltyDepartmentPackingSlip,
            BookPayment _bookPayment,
            CommisionPayment _commisionPayment,
            ActivateMembership _activateMembership,
            UpGradeMembership _upGradeMembership,
            PhysicalProductPayment _physicalProductPayment,
            MembershipActivatePayment _membershipActivatePayment,
            MembershipUpgradePayment _membershipUpgradePayment,
            SendEmail _sendEMail,
            VideoPayment _videoPayment
            )
        {
            royaltyDepartmentPackingSlip = _royaltyDepartmentPackingSlip;
            bookPayment = _bookPayment;
            commisionPayment = _commisionPayment;
            activateMembership = _activateMembership;
            upGradeMembership = _upGradeMembership;
            physicalProductPayment = _physicalProductPayment;
            membershipActivatePayment = _membershipActivatePayment;
            membershipUpgradePayment = _membershipUpgradePayment;
            sendEmail = _sendEMail;
        }
        public void ProcessInventoryOrder(Enum.Enum.ProductType productType)
        {
            switch(productType)
            {
                case Enum.Enum.ProductType.Book:
                    bookPayment.ProcessPayment();
                    commisionPayment.ProcessPayment();
                    royaltyDepartmentPackingSlip.GeneratePackingSlip();
                    break;
                case Enum.Enum.ProductType.MembershipActivation:
                    membershipActivatePayment.ProcessPayment();
                    activateMembership.ProcessMembership();
                    sendEmail.SendMail();   
                    break;
                case Enum.Enum.ProductType.MembershipUpgrade:
                    membershipUpgradePayment.ProcessPayment();
                    upGradeMembership.ProcessMembership();
                    sendEmail.SendMail();
                    break;
                case Enum.Enum.ProductType.PhysicalProduct:
                    physicalProductPayment.ProcessPayment();
                    commisionPayment.ProcessPayment();
                    break;
                case Enum.Enum.ProductType.Video:
                    videoPayment.ProcessPayment();
                    break;
            }
            
        }
    }
}
