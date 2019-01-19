namespace JIPP5ZaliczenieMG
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JiPPmgronczewski.Notki")]
    public partial class Notki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Notki()
        {
            Fiszkis = new HashSet<Fiszki>();
            Fiszkis1 = new HashSet<Fiszki>();
        }

        public int id { get; set; }

        public string tekst { get; set; }

        public int? idPliku { get; set; }

        public int? idZrodla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fiszki> Fiszkis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fiszki> Fiszkis1 { get; set; }

        public virtual Pliki Pliki { get; set; }

        public virtual Zrodlo Zrodlo { get; set; }
    }
}
