namespace JIPP5ZaliczenieMG
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JiPPmgronczewski.Pojecia")]
    public partial class Pojecia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pojecia()
        {
            Fiszkis = new HashSet<Fiszki>();
        }

        public int id { get; set; }

        [Required]
        public string nazwa { get; set; }

        [StringLength(100)]
        public string tag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fiszki> Fiszkis { get; set; }
    }
}
