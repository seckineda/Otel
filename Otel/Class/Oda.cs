using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class
{
    
    public enum OdaSayisi
    {
     TekkişilikOda,
     ÇiftKisilikOda,
     Lux,
     Kral
    }
    [Table("Odalar")]
    public class Oda:DbObject.DbObject
    {
        public Oda(bool bosMu, int ucret)
        {
            BosMu = bosMu;
            Ucret = ucret;
        }

        public Otel OtelId{ get; set; }
        public OdaSayisi odaSayisi { get; set; }
        [Required]
        public bool BosMu { get; set; }
        [DataType(DataType.Currency)]
        public int Ucret { get; set; }
        [MaxLength(10)]
        [Required]
        public string OdaNumarası { get; set; }

        public Oda()
        {

        }
        public override string ToString()
        {
            return "Odasi" + odaSayisi;
        }
    }
}
