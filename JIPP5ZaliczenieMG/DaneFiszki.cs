namespace JIPP5ZaliczenieMG
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JiPPmgronczewski.DaneFiszki")]
    public partial class DaneFiszki
    {
        public int id { get; set; }

        public int idFiszki { get; set; }

        public bool? ostatniRezultat { get; set; }

        public DateTime dataUtworzenia { get; set; }

        public DateTime dataOstatniegoPowtorzenia { get; set; }

        public int? iloscPoprawnychOdpowiedzi { get; set; }

        public virtual Fiszki Fiszki { get; set; }
    }
}
