using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class
{
    [Table("İlçeler")]
    public  class Ilce:DbObject.DbObject
    {
        public Ilce(string ılceAdi, List<Mahalle> mahalleler)
        {
            IlceAdi = ılceAdi;
            Mahalleler = mahalleler;
        }
        public Ilce()
        {

        }
        [MaxLength(50)]
        [Required]
        public string IlceAdi { get; set; }
        [MaxLength(50)][Required]

        public List<Mahalle> Mahalleler { get; set; } 
        public override string ToString()
        {
            return "Ilcesinde :" + IlceAdi;
        }
    }
}
