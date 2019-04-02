using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class
{
    [Table("Oteller")]
    public class Otel:DbObject.DbObject
    {
        [MaxLength(50)]
        [Required]
        public Il Adresi { get; set; }
        [Required]
        public int VergiNo { get; set; }
        [MaxLength(50)]
        [Required]
        public string Adi { get; set; }
        [MaxLength(50)]
        [Required]
        public string ResmiAdi { get; set; }
        [MaxLength(150)]
        public string Aciklama { get; set; }
        [MaxLength(200)]
        public List<Yorum> Yorumlar { get; set; }
        [MaxLength(50)]
        [Required]
        public List<Yıldız>Yıdızlar { get; set; }


        public Otel(string adi, string resmiAdi, string aciklama)
        {
            Adi = adi;
            ResmiAdi = resmiAdi;
            Aciklama = aciklama;
        }
        public Otel()
        {

        }
        public override string ToString()
        {
            return "Otelin" + Adi;
        }
    }
}
