namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PromotionBranchApply")]
    public partial class PromotionBranchApply
    {
        public Guid PromotionBranchApplyID { get; set; }

        public Guid? PromitionID { get; set; }

        public Guid? BranchID { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
}
