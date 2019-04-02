using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class
{
    [Table("Ozellikler")]
    public  class Ozellik:DbObject.DbObject
    {
        public Ozellik()
        {
         
        }
        [Required]
        [MaxLength(50)]
        public string OzellikAdi { get; set; }
        public override string ToString()
        {
            return "ozellik" + OzellikAdi;
        }
    }
    
}
