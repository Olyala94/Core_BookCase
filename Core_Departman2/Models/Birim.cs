using System.ComponentModel.DataAnnotations;

namespace Core_Departman2.Models
{
    public class Birim
    {
        [Key]
        public int BirimId { get; set; }

        public string BirimAdi { get; set; }

        public IList<Personel> Personels { get; set; }
    }
}
