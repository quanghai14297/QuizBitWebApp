namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PromotionDetail")]
    public partial class PromotionDetail
    {
        public Guid PromotionDetailID { get; set; }

        public Guid? PromotionID { get; set; }

        public Guid? InventoryItemID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? ConditionQuantity { get; set; }

        public decimal? DiscountRate { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? Amount { get; set; }

        public int SortOrder { get; set; }

        public virtual InventoryItem InventoryItem { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
}
