//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AllPointsTransport.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WOLineItem
    {
        public int ID { get; set; }
        public Nullable<int> WorkOrder { get; set; }
        public Nullable<int> RowOrder { get; set; }
        public string BillingItem { get; set; }
        public string Description { get; set; }
        public string Vendor { get; set; }
        public string VendorReference { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<bool> Fee { get; set; }
        public Nullable<bool> PayDriver { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
