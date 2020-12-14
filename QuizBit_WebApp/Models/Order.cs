namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            SAInvoices = new HashSet<SAInvoice>();
        }

        public Guid OrderID { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderNo { get; set; }

        public int OrderStatus { get; set; }

        public DateTime? OrderDate { get; set; }

        public Guid? BranchID { get; set; }

        public Guid? CustomerID { get; set; }

        public int? NumberOfPeople { get; set; }

        public Guid? BookingID { get; set; }

        public Guid? EmployeeID { get; set; }

        public Guid? CancelEmployeeID { get; set; }

        [StringLength(255)]
        public string CancelReason { get; set; }

        public Guid? TableID { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(255)]
        public string ModifiedBy { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual TableMapping TableMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAInvoice> SAInvoices { get; set; }
    }
}
