namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryItemCategory")]
    public partial class InventoryItemCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryItemCategory()
        {
            InventoryItems = new HashSet<InventoryItem>();
        }

        public Guid InventoryItemCategoryID { get; set; }

        [StringLength(50)]
        public string InventoryItemCategoryCode { get; set; }

        [StringLength(255)]
        public string InventoryItemCategoryName { get; set; }

        public string Description { get; set; }

        public int? SortOrder { get; set; }

        public bool? Inactive { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(255)]
        public string ModifiedBy { get; set; }

        public string OldIDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
    }
}
