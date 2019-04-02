using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class
{
    [Table("Yorumlar")]
    public  class Yorum:DbObject.DbObject
    {
        public Yorum()
        {
           
        }
        [Required]
        public Musteri MusteriId { get; set; }
        [MaxLength(50)]
        public string YorumBasligi { get; set; }
        [MaxLength(200)]
        public string Yorumİcerigi { get; set; }
        public  List<Yıldız> Yıldızlar { get; set; }

        public override string ToString()
        {
            return "Bilgiler" + MusteriId + "YorumBaslığınız" + YorumBasligi + "Yorumİçeriğiniz" + Yorumİcerigi;
        }
    }
    
}
