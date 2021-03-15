using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;



namespace TasteUfes.Controllers
{
	[Authorize]
	[ApiController]
	[Route("api/[controller]")]
	public class FoodsController : BaseController
	{
		
			private readonly IFoodService _foodService;
		
			private readonly INutrientService _nutrientService;
		
			private readonly INutritionFactsService _nutritionFactsService;
		
		
		public FoodsController(IFoodService foodService, INutrientService nutrientService, INutritionFactsService nutritionFactsService, IMapper mapper, INotificator notificator)
			: base(mapper, notificator)
		{
			
				_foodService = foodService;
			
				_nutrientService = nutrientService;
			
				_nutritionFactsService = nutritionFactsService;
			
		}
		
		
			

			
				[HttpPost]
			
			public IActionResult Post(Food food)
			{
				throw new NotImplementedException();
			}
		
			

			
				[HttpPut]
			
			public IActionResult Put(Guid id, Food food)
			{
				throw new NotImplementedException();
			}
		
			

			
				[HttpGet]
			
			public IActionResult Get()
			{
				throw new NotImplementedException();
			}
		
			

			
				[HttpGet]
			
			public IActionResult Get(Guid id)
			{
				throw new NotImplementedException();
			}
		
			

			
				[HttpDelete]
			
			public IActionResult Delete(Guid id)
			{
				throw new NotImplementedException();
			}
		
	}
}