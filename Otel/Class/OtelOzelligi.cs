using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class
{
    [Table("Otel Özellikleri")]
    public  class OtelOzelligi: DbObject.DbObject
    {
        public OtelOzelligi()
        {
            
        }
        [MaxLength(50)]
        [Required]
        public Otel OtelId { get; set; }
        [Required]
        [MaxLength(50)]
        public Ozellik OzellikId { get; set; }
        public override string ToString()
        {
            return "Otelin Ozelliği" + OzellikId;
        }

    }
}
