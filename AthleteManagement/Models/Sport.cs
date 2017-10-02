namespace AthleteManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sport()
        {
            Athletes = new HashSet<Athlete>();
        }

        [Key]
        public int Pk_Sport_Id { get; set; }

        [Column("Sport")]
        [StringLength(255)]
        public string Sport1 { get; set; }

        [StringLength(255)]
        public string Contact { get; set; }

        [StringLength(255)]
        public string Season { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Athlete> Athletes { get; set; }
    }
}
