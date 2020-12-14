namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAInvoiceDetail")]
    public partial class SAInvoiceDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid RefDetailID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RefID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ItemID { get; set; }

        public Guid? ItemAdditionID { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal Quantity { get; set; }

        public decimal? QuantityAddition { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal UnitPrice { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal SaleAmount { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal DiscountRate { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal DiscountAmount { get; set; }

        public string Description { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SortOrder { get; set; }

        public Guid? PromotionID { get; set; }

        public Guid? OrderDetailID { get; set; }

        public virtual OrderDetail OrderDetail { get; set; }

        public virtual Promotion Promotion { get; set; }

        public virtual SAInvoice SAInvoice { get; set; }
    }
}
