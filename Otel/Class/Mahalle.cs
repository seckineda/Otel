using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class
{
    [Table("Mahalleler")]
    public  class Mahalle:DbObject.DbObject
    {
        public Mahalle(string mahalleAdi)
        {
            MahalleAdi = mahalleAdi;
        }
        public Mahalle()
        {

        }
        [MaxLength(50)]
        [Required]
        public string MahalleAdi{ get; set; }

        public override string ToString()
        {
            return "Mahalle Adi" + MahalleAdi;
        }

    }
}
