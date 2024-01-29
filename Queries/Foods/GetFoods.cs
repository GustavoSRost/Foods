namespace Lanche.Queries.Foods.GetFoods
{
    public class GetFoodsQuery
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string SmallDescription { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ThumbImage { get; set; }
		public string Image { get; set; }
		public bool? Favorite { get; set; }
		public bool IsAvailable { get; set; }
		public int CategoryId { get; set; }
        public int? Take {get; set;}
        public int? Skip {get; set;}
        

    }
};


