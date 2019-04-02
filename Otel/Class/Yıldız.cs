using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class
{
    [Table("Yıldızlar")]
    public  class Yıldız:DbObject.DbObject
    {
        public Yıldız()
        {

        }
        [Required]
        public int BegenmeSayisi { get; set; }
        [Required]
        public int BegenmemeSayisi { get; set; }
    }
}
