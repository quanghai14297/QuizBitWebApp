namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAInvoice")]
    public partial class SAInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAInvoice()
        {
            SAInvoiceDetails = new HashSet<SAInvoiceDetail>();
        }

        [Key]
        public Guid RefID { get; set; }

        public Guid? BranchID { get; set; }

        public Guid? OrderID { get; set; }

        [Required]
        [StringLength(50)]
        public string RefNo { get; set; }

        public DateTime RefDate { get; set; }

        public Guid? CustomerID { get; set; }

        public decimal TotalSaleAmount { get; set; }

        public decimal TotalDiscountAmount { get; set; }

        public decimal ServiceRate { get; set; }

        public decimal ServiceAmount { get; set; }

        public Guid? PromotionID { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal VATRate { get; set; }

        public decimal VATAmount { get; set; }

        public decimal PaymentAmount { get; set; }

        public decimal? ReceiveAmount { get; set; }

        public decimal ReturnAmount { get; set; }

        public decimal? OtherPromotionAmount { get; set; }

        [StringLength(255)]
        public string JournalMemo { get; set; }

        [StringLength(255)]
        public string CancelReason { get; set; }

        public int PaymentStatus { get; set; }

        public Guid? EmployeeID { get; set; }

        public bool? IsApplyTaxWhenRequire { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(255)]
        public string ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Order Order { get; set; }

        public virtual Promotion Promotion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAInvoiceDetail> SAInvoiceDetails { get; set; }
    }
}
