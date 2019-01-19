namespace JIPP5ZaliczenieMG
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JiPPmgronczewski.Fiszki")]
    public partial class Fiszki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fiszki()
        {
            DaneFiszkis = new HashSet<DaneFiszki>();
        }

        public int id { get; set; }

        public int idPojecie { get; set; }

        public int pytanie { get; set; }

        public int odpowiedz { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaneFiszki> DaneFiszkis { get; set; }

        public virtual Pojecia Pojecia { get; set; }

        public virtual Notki Notki { get; set; }

        public virtual Notki Notki1 { get; set; }
    }
}
