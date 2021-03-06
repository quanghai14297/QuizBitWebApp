namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kitchen")]
    public partial class Kitchen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kitchen()
        {
            SendKitchens = new HashSet<SendKitchen>();
        }

        public Guid KitchenID { get; set; }

        public Guid? BranchID { get; set; }

        [StringLength(255)]
        public string KitchenName { get; set; }

        public string Description { get; set; }

        public bool? Inactive { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(255)]
        public string ModifiedBy { get; set; }

        public string OldIDs { get; set; }

        public virtual Branch Branch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SendKitchen> SendKitchens { get; set; }
    }
}
