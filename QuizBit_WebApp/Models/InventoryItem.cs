namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryItem")]
    public partial class InventoryItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryItem()
        {
            BookingDetails = new HashSet<BookingDetail>();
            OrderDetails = new HashSet<OrderDetail>();
            PromotionDetails = new HashSet<PromotionDetail>();
            PromotionQuantityConditions = new HashSet<PromotionQuantityCondition>();
        }

        public Guid InventoryItemID { get; set; }

        [StringLength(255)]
        public string InventoryItemCode { get; set; }

        [Required]
        [StringLength(255)]
        public string InventoryItemName { get; set; }

        public int? InventoryItemType { get; set; }

        public Guid? InventoryItemCategoryID { get; set; }

        public Guid? UnitID { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] FileResource { get; set; }

        public int? CourseType { get; set; }

        public decimal? UnitPrice { get; set; }

        public bool? Inactive { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(255)]
        public string ModifiedBy { get; set; }

        public string OldIDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }

        public virtual InventoryItemCategory InventoryItemCategory { get; set; }

        public virtual Unit Unit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromotionDetail> PromotionDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromotionQuantityCondition> PromotionQuantityConditions { get; set; }
    }
}
