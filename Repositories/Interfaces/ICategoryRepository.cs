using Lanche.Models;

namespace Foods.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories {get;}
    }
}