namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingDetail")]
    public partial class BookingDetail
    {
        public Guid BookingDetailID { get; set; }

        public Guid BookingID { get; set; }

        public Guid? InventoryItemID { get; set; }

        public decimal? Quantity { get; set; }

        [StringLength(255)]
        public string Desciption { get; set; }

        public int? BookingDetailStatus { get; set; }

        public int SortOrder { get; set; }

        public Guid? SendKitchenID { get; set; }

        [StringLength(255)]
        public string CancelName { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual InventoryItem InventoryItem { get; set; }

        public virtual SendKitchen SendKitchen { get; set; }
    }
}
