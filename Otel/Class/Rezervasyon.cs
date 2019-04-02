using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class
{
    public enum OdemeZamani
    {
        RezervasyondaOdendi,
        OteldeOdendi
    }
    [Table("Rezervasyonlar")]
    public   class Rezervasyon:DbObject.DbObject
    {
        public Rezervasyon( DateTime checkInDate, DateTime checkOutDate)
        {
           
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
        public Rezervasyon()
        {

        }
        [Required]
        public Musteri MusteriId { get; set; }
        [Required]
        public Oda OdaId { get; set; }
        public int KisiSayisi { get; set; }
        [Required]
        public  DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }

        public override string ToString()
        {
            return "OdaSayısı" + OdaId + "Musteri" + MusteriId;
        }
    }
}
