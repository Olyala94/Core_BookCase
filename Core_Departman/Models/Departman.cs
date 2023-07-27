using System.ComponentModel.DataAnnotations;

namespace Core_Departman.Models
{
	public class Departman
	{
		[Key]
		public int Id { get; set; }

		public string? DepartmanAdi { get; set; }
	}
}
