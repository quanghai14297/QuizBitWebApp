namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            BookingDetails = new HashSet<BookingDetail>();
            Orders = new HashSet<Order>();
        }

        public Guid BookingID { get; set; }

        [Required]
        [StringLength(50)]
        public string BookingNo { get; set; }

        public DateTime BookingDate { get; set; }

        public int BookingStatus { get; set; }

        public Guid? BranchID { get; set; }

        public Guid? CustomerID { get; set; }

        public int? NumberOfPeople { get; set; }

        public DateTime? FromTime { get; set; }

        public string RequestMeal { get; set; }

        public string RequestOther { get; set; }

        public bool? IsArrangedTable { get; set; }

        public string TableDescription { get; set; }

        public bool? IsOrderFood { get; set; }

        public string RequestKitchen { get; set; }

        [StringLength(255)]
        public string CancelDescription { get; set; }

        [StringLength(255)]
        public string PaymentDescription { get; set; }

        public Guid? EmployeeID { get; set; }

        public Guid? TableID { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(255)]
        public string ModifiedBy { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual TableMapping TableMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
