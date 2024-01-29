using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lanche.Models
{
	[Table("Foods")]
	public class Food
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string Name { get; set; }

		[StringLength(50)]
		public string SmallDescription { get; set; }
		public string Description { get; set; }
		[Required]
		[Range(1, 999.99)]
		[Column(TypeName = "decimal(10,2)")]
		public decimal Price { get; set; }
		public string ThumbImage { get; set; }
		[Required]
		public string Image { get; set; }
		public bool? Favorite { get; set; }
		[Required]
		public bool IsAvailable { get; set; }

		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }
	}
}

