namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Bookings = new HashSet<Booking>();
            Orders = new HashSet<Order>();
            SAInvoices = new HashSet<SAInvoice>();
            SendKitchens = new HashSet<SendKitchen>();
        }

        public Guid EmployeeID { get; set; }

        public Guid? BranchID { get; set; }

        [StringLength(50)]
        public string EmployeeCode { get; set; }

        [StringLength(255)]
        public string EmployeeName { get; set; }

        public int? Gender { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(255)]
        public string BirthPlace { get; set; }

        [StringLength(255)]
        public string HomeLand { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string HomePhone { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [Column(TypeName = "image")]
        public byte[] Avatar { get; set; }

        public Guid? UserID { get; set; }

        public int? RoleID { get; set; }

        [StringLength(50)]
        public string IdentifyNumber { get; set; }

        [StringLength(255)]
        public string IdentifyNumberIssuedPlace { get; set; }

        public DateTime? IdentifyNumberIssuedDate { get; set; }

        public string Description { get; set; }

        [StringLength(255)]
        public string MaritalStatus { get; set; }

        [StringLength(255)]
        public string Religion { get; set; }

        [StringLength(255)]
        public string Nationality { get; set; }

        public int? JobStatus { get; set; }

        public DateTime? ProbationDate { get; set; }

        public DateTime? ReceiveDate { get; set; }

        public DateTime? TerminationDate { get; set; }

        [StringLength(255)]
        public string ReasonTermination { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual Role Role { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAInvoice> SAInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SendKitchen> SendKitchens { get; set; }
    }
}
