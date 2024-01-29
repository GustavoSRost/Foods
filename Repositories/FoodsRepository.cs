using Foods.Repositories.Interfaces;
using Lanche.Context;
using Lanche.Models;
using Microsoft.EntityFrameworkCore;

namespace Foods.Repositories
{
    public class FoodRepository : IFoodsRepository
    {

        private readonly AppDbContext _context;

        public FoodRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Food> Foods => _context.Foods.Include(c => c.Category);
        public IEnumerable<Food> FavoriteFood => _context.Foods.Where(p => (bool)p.Favorite).Include(c => c.Category);

        public Food GetFoodById(int id) => _context.Foods.FirstOrDefault(i => i.Id == id);
    }
}