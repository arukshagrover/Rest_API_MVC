using System;
using System.Collections.Generic;

namespace BillAPIProject.Models
{
    public partial class Table1
    {
        public string PartnerId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MpnId { get; set; }
        public string OrderId { get; set; }
        public string SubscriptionId { get; set; }
        public string SyndicationPartnerSubscriptionNumber { get; set; }
        public string OfferId { get; set; }
        public string DurableOfferId { get; set; }
        public string OfferName { get; set; }
        public DateTime? SubscriptionStartDate { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        public DateTime? ChargeStartDate { get; set; }
        public DateTime? ChargeEndDate { get; set; }
        public string ChargeType { get; set; }
        public float? UnitPrice { get; set; }
        public decimal? Quantity { get; set; }
        public float? Amount { get; set; }
        public float? TotalOtherDiscount { get; set; }
        public float? Subtotal { get; set; }
        public float? Tax { get; set; }
        public float? TotalForCustomer { get; set; }
        public string Currency { get; set; }
        public string DomainName { get; set; }
        public string SubscriptionName { get; set; }
        public string SubscriptionDescription { get; set; }
        public string BillingCycleType { get; set; }
    }
}
