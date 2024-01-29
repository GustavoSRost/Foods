using Foods.Repositories.Interfaces;
using Lanche.Queries.Foods.GetFoods;
using Microsoft.AspNetCore.Mvc;

namespace Lanche.Controllers
{
    [Route("foods")]
    public class FoodController : Controller
    {
        private readonly IFoodsRepository _foodRepository;

        public FoodController(IFoodsRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        [HttpGet]
        public IActionResult GetFoods([FromQuery] GetFoodsQuery foods)
        {
            var result = _foodRepository.Foods;
            if(result.Count == 0)
                ModelState.AddModelError("", "No foods.");
        }

    }

}


