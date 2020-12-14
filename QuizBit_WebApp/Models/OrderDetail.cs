namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderDetail()
        {
            SAInvoiceDetails = new HashSet<SAInvoiceDetail>();
        }

        public Guid OrderDetailID { get; set; }

        public Guid OrderID { get; set; }

        public Guid? InventoryItemID { get; set; }

        public Guid? InventoryItemAdditionID { get; set; }

        public decimal Quantity { get; set; }

        [StringLength(10)]
        public string QuantityAddition { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public decimal? CookedQuantity { get; set; }

        public decimal? ServedQuantity { get; set; }

        public decimal? CookingQuantity { get; set; }

        public int? OrderDetailStatus { get; set; }

        public Guid? CancelEmployeeID { get; set; }

        public Guid? SendKitchenID { get; set; }

        public virtual InventoryItem InventoryItem { get; set; }

        public virtual Order Order { get; set; }

        public virtual SendKitchen SendKitchen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAInvoiceDetail> SAInvoiceDetails { get; set; }
    }
}
