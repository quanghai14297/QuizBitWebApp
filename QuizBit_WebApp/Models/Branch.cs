namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Branch")]
    public partial class Branch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Branch()
        {
            Areas = new HashSet<Area>();
            Kitchens = new HashSet<Kitchen>();
            Orders = new HashSet<Order>();
            PromotionBranchApplies = new HashSet<PromotionBranchApply>();
            SAInvoices = new HashSet<SAInvoice>();
        }

        public Guid BranchID { get; set; }

        [StringLength(50)]
        public string BranchCode { get; set; }

        [Required]
        [StringLength(255)]
        public string BranchName { get; set; }

        [StringLength(255)]
        public string BranchAddress { get; set; }

        [StringLength(50)]
        public string BranchTel { get; set; }

        public string Description { get; set; }

        public bool Inactive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Area> Areas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kitchen> Kitchens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromotionBranchApply> PromotionBranchApplies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAInvoice> SAInvoices { get; set; }
    }
}
