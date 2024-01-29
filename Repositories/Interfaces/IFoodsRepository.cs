using Lanche.Models;

namespace Foods.Repositories.Interfaces
{
    public interface IFoodsRepository
    {
        IEnumerable<Food> Foods {get;}
    }
}