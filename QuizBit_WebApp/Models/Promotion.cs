namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Promotion")]
    public partial class Promotion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Promotion()
        {
            PromotionBranchApplies = new HashSet<PromotionBranchApply>();
            PromotionDetails = new HashSet<PromotionDetail>();
            PromotionQuantityConditions = new HashSet<PromotionQuantityCondition>();
            SAInvoices = new HashSet<SAInvoice>();
            SAInvoiceDetails = new HashSet<SAInvoiceDetail>();
        }

        public Guid PromotionID { get; set; }

        [StringLength(255)]
        public string PromotionName { get; set; }

        public string Description { get; set; }

        public int? PromotionType { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public DateTime? FromTime { get; set; }

        public DateTime? ToTime { get; set; }

        public decimal? DiscountRate { get; set; }

        public decimal? DiscountAmount { get; set; }

        public int? PromotionObject { get; set; }

        public int? PromotionCondition { get; set; }

        public decimal? ConditionAmount { get; set; }

        public int? ApplyType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromotionBranchApply> PromotionBranchApplies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromotionDetail> PromotionDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromotionQuantityCondition> PromotionQuantityConditions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAInvoice> SAInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAInvoiceDetail> SAInvoiceDetails { get; set; }
    }
}
