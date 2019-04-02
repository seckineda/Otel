using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class
{
    [Table("Musteriler")]
    public  class Musteri:DbObject.DbObject
    {
        public Musteri(string adi, string soyadi, int sifre, string telefonNum, string email)
        {
            Adi = adi;
            Soyadi = soyadi;
            Sifre = sifre;
            TelefonNum = telefonNum;
            Email = email;
        }
        public Musteri()
        {

        }
        [MaxLength(50)]
        public string Adi { get; set; }
        [MaxLength(50)]
        [Required]
        public string Soyadi { get; set; }
        [Required]
        public int Sifre { get; set; }
        [MaxLength(11)]
        [Required]
        public string TelefonNum { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(11)]
        public string TcKimlik { get; set; }
        [MaxLength(50)]
        [Required]
        public string KullaniciAdi { get; set; }

        public override string ToString()
        {
            return "MusteriAdi" + Adi;
        }

    }
}
