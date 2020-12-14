namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Area")]
    public partial class Area
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Area()
        {
            TableMappings = new HashSet<TableMapping>();
        }

        public Guid AreaID { get; set; }

        [StringLength(255)]
        public string AreaName { get; set; }

        public Guid? BranchID { get; set; }

        public string Description { get; set; }

        public int? NumberOfTable { get; set; }

        [Column(TypeName = "image")]
        public byte[] Background { get; set; }

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
        public virtual ICollection<TableMapping> TableMappings { get; set; }
    }
}
