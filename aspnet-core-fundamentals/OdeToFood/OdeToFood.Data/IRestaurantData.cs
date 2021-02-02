using OdeToFood.Core;

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
	public interface IRestaurantData
	{
		IEnumerable<Restaurant> GetAll();
	}

	public class InMemoryRestaurantData : IRestaurantData
	{
		readonly List<Restaurant> restaurants;
		public InMemoryRestaurantData()
		{
			this.restaurants = new List<Restaurant>()
			{
				new Restaurant{Id = 1, Name = "Pizzazaaa", Location = "London", Cuisine = CuisineType.Mexican},
				new Restaurant{Id = 2, Name = "Yummy Pasta", Location = "Toronto", Cuisine = CuisineType.Italian},
				new Restaurant{Id = 3, Name = "Spiced Rice", Location = "Sydney", Cuisine = CuisineType.Indian},
			};
		}

		public IEnumerable<Restaurant> GetAll()
		{
			return this.restaurants.OrderBy(r => r.Name);
		}
	}
}
