using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lanche.Models
{
	[Table("Categories")]
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
        public string Description { get; set; }
		[Required]
		[StringLength(100)]
		public string Name { get; set; }

		public List<Food> Foods { get; set; }
	}
}

