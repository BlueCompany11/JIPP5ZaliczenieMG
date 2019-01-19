namespace JIPP5ZaliczenieMG
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JiPPmgronczewski.Pliki")]
    public partial class Pliki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pliki()
        {
            Notkis = new HashSet<Notki>();
        }

        public int id { get; set; }

        [Required]
        public byte[] binarka { get; set; }

        [Required]
        [StringLength(100)]
        public string nazwaZRozszerzeniem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notki> Notkis { get; set; }
    }
}
