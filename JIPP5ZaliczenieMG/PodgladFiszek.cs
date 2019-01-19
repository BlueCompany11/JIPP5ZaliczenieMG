namespace JIPP5ZaliczenieMG
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JiPPmgronczewski.PodgladFiszek")]
    public partial class PodgladFiszek
    {
        [Column("Numer pojecia")]
        public int? Numer_pojecia { get; set; }

        [Key]
        [Column("Numer Fiszki")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numer_Fiszki { get; set; }

        public string Pytanie { get; set; }

        [Column("Data ostatniego Powtorzenia")]
        public DateTime? Data_ostatniego_Powtorzenia { get; set; }
    }
}
