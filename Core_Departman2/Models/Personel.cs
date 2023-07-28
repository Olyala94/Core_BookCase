using System.ComponentModel.DataAnnotations;

namespace Core_Departman2.Models
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; } 

        public string Sehir { get; set; }

        public int BirimId { get; set;}

        public Birim Birim { get; set; }
    }
}
