namespace QuizBit_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserJoinRole")]
    public partial class UserJoinRole
    {
        public Guid UserJoinRoleID { get; set; }

        public Guid? UserID { get; set; }

        public int RoleID { get; set; }

        public virtual Role Role { get; set; }

        public virtual User User { get; set; }
    }
}
