using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class
{
    [Table("İller")]
    public  class Il:DbObject.DbObject
    {
       
        public Il(string ılADi, List<Ilce> ılceler)
        {
            IlADi = ılADi;
            Ilceler = ılceler;
        }
        public Il()
        {

        }
        [MaxLength(50)]
        [Required]
        public string IlADi { get; set; }
        [Required]
        [MaxLength(50)]

        public List<Ilce> Ilceler { get; set; }

        public override string ToString()
        {
            return "IlınAdi" + IlADi;
        }
    }
}
