namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PromotionQuantityCondition")]
    public partial class PromotionQuantityCondition
    {
        public Guid PromotionQuantityConditionID { get; set; }

        public Guid? PromotionID { get; set; }

        public Guid? InventoryItemID { get; set; }

        public decimal? Quantity { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(255)]
        public string ModifiedBy { get; set; }

        public virtual InventoryItem InventoryItem { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
}
