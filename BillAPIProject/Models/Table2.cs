using System;
using System.Collections.Generic;

namespace BillAPIProject.Models
{
    public partial class Table2
    {
        public string PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string PartnerBillableAccountId { get; set; }
        public string CustomerCompanyName { get; set; }
        public string MpnId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? ChargeStartDate { get; set; }
        public DateTime? ChargeEndDate { get; set; }
        public string SubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public string SubscriptionDescription { get; set; }
        public string OrderId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceType { get; set; }
        public string ResourceGuid { get; set; }
        public string ResourceName { get; set; }
        public string Region { get; set; }
        public string Sku { get; set; }
        public decimal? DetailLineItemId { get; set; }
        public float? ConsumedQuantity { get; set; }
        public float? IncludedQuantity { get; set; }
        public float? OverageQuantity { get; set; }
        public float? ListPrice { get; set; }
        public float? PretaxCharges { get; set; }
        public float? TaxAmount { get; set; }
        public float? PostTaxTotal { get; set; }
        public string Currency { get; set; }
        public float? PretaxEffectiveRate { get; set; }
        public float? PostTaxEffectiveRate { get; set; }
        public string ChargeType { get; set; }
        public string CustomerId { get; set; }
        public string DomainName { get; set; }
        public string BillingCycleType { get; set; }
        public string Unit { get; set; }
        public decimal Row { get; set; }
    }
}
