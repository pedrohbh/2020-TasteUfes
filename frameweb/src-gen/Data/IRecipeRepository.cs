using SCAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Data
{
	public interface IRecipeRepository : IEntityRepository<Recipe>
	{
		
			

			
				
			

			Recipe GetDetailed(Guid id);
		
	}
}