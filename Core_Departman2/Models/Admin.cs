using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core_Departman2.Models
{
	public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string UserName { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string Password { get; set; }
    }
}
