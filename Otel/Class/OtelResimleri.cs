using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class
{
    [Table("Otel Resimleri")]
    public  class OtelResimleri:DbObject.DbObject
    {
        [Required]
        public Otel OtelId { get; set; }
        [Required]
        public byte[] Resim = { };

        public OtelResimleri(byte[] resim)
        {
            Resim = resim;
        }
        public OtelResimleri()
        {

        }
        public override string ToString()
        {
            return "Otelimizin Id'si" + OtelId;
        }
    }
}
