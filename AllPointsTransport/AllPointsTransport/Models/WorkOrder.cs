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
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("WorkOrders")]
    public partial class WorkOrder
    {
        public int WorkOrderID { get; set; }
        public Nullable<int> WorkOrderNo { get; set; }
        public Nullable<bool> Completed { get; set; }
        public string Status { get; set; }
        public System.DateTime InvoicedDate { get; set; }
        public System.DateTime DatePaid { get; set; }
        public string Broker { get; set; }
        public string BillTo { get; set; }
        public string Container1 { get; set; }
        public string Seal { get; set; }
        public Nullable<bool> StreetTurn { get; set; }
        public string EquipmentSize { get; set; }
        public string Chassis { get; set; }
        public string EquipmentProvider { get; set; }
        public string ChassisProvider { get; set; }
        public string Booking { get; set; }
        public string MasterBOL { get; set; }
        public string Reference { get; set; }
        public string Pro { get; set; }
        public string ApptNumber { get; set; }
        public string Release { get; set; }
        public string Weight { get; set; }
        public string PieceCount { get; set; }
        public string Commodity { get; set; }
        public string PO { get; set; }
        public string EquipmentPickup { get; set; }
        public string EquipmentReturn { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string TypeOfMove { get; set; }
        public Nullable<int> Duration { get; set; }
        public System.DateTime StorageLFD { get; set; }
        public Nullable<System.DateTime> PerDiemLFD { get; set; }
        public System.DateTime Cutoff { get; set; }
        public System.DateTime ApptTime { get; set; }
        public string Container2 { get; set; }
        public string LocationHours { get; set; }
        public Nullable<System.DateTime> OutgateReceipt { get; set; }
        public Nullable<System.DateTime> IngateReceipt { get; set; }
        public Nullable<System.DateTime> ReadyNotification { get; set; }
        public string NotesInvoice { get; set; }
        public string NotesPrivate { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
        public string LinkedProNum { get; set; }
        public string InfoSymbol { get; set; }
        public Nullable<decimal> BilledAmount { get; set; }
        public Nullable<bool> AcceptedByDispatch { get; set; }
        public Nullable<bool> RejectedByDispatch { get; set; }
        public Nullable<bool> POD1 { get; set; }
        public Nullable<bool> POD2 { get; set; }
        public Nullable<bool> BOL { get; set; }
        public Nullable<bool> Uploaded { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
       
    }
}
