using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

using OdeToFood.Core;
using OdeToFood.Data;

using System.Collections.Generic;

namespace OdeToFood.Pages.Restaurants
{
	public class ListModel : PageModel
	{
		private readonly IConfiguration configuration;
		private readonly IRestaurantData restaurantData;
		public string Message { get; set; }
		public IEnumerable<Restaurant> Restaurants { get; set; }

		public ListModel(
			IConfiguration configuration,
			IRestaurantData restaurantData)
		{
			this.configuration = configuration;
			this.restaurantData = restaurantData;
		}

		public void OnGet()
		{
			this.Message = this.configuration["Message"];
			this.Restaurants = this.restaurantData.GetAll();
		}
	}
}
