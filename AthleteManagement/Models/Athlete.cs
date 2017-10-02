namespace AthleteManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Athlete
    {
        [Key]
        public int Pk_Athlete_Id { get; set; }

        [StringLength(255)]
        public string FullName { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(10)]
        public string MobileNo { get; set; }

        public int? Fk_Sport_Id { get; set; }

        public virtual Sport Sport { get; set; }
    }
}
