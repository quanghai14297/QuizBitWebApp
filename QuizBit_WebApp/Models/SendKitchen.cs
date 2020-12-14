namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SendKitchen")]
    public partial class SendKitchen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SendKitchen()
        {
            BookingDetails = new HashSet<BookingDetail>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public Guid SendKitchenID { get; set; }

        public Guid? KitchenID { get; set; }

        public string DataContent { get; set; }

        public Guid? SenderID { get; set; }

        public DateTime? SendDate { get; set; }

        public string Description { get; set; }

        public Guid? InventoryItemID { get; set; }

        public int? SendKitchenType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Kitchen Kitchen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
