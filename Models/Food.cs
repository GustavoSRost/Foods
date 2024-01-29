using System.ComponentModel.DataAnnotations;
namespace Lanche.Models
{
	public class Food
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public string SmallDescription { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ThumbImage { get; set; }
		public string Image { get; set; }
		public bool Favorite { get; set; }
		public bool IsAvailable { get; set; }

		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }
	}
}

