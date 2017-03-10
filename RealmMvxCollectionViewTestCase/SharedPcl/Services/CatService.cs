using System;
using System.Collections.Generic;
using SharedPcl.DataModels;
using Realms;
using System.Linq;

namespace SharedPcl.Services
{
	public interface ICatService
	{
		void CreateCats();
		IRealmCollection<Cat> GetCats();
	}

	public class CatService : ICatService 
	{
		private readonly IRealmService _realmService;

		public CatService(IRealmService realmService)
		{
			_realmService = realmService;
		}

		public void CreateCats()
		{
			var query = _realmService.QueryAll<Cat>();

			var anyCats = query.Any();

			if (!anyCats)
			{
				// CREATE SOME CATS!!!!!!

				var cats = new List<Cat>();

				var cat1 = new Cat { Id = "cat1", Name = "Mr. Tiddles", ImageUrl = "https://i.ytimg.com/vi/tntOCGkgt98/maxresdefault.jpg" };
				var cat2 = new Cat { Id = "cat2", Name = "Fluff", ImageUrl = "https://img1.wsimg.com/fos/sales/cwh/8/images/cats-with-hats-shop-06.jpg" };
				var cat3 = new Cat { Id = "cat3", Name = "Rusty", ImageUrl = "https://s-media-cache-ak0.pinimg.com/736x/07/c3/45/07c345d0eca11d0bc97c894751ba1b46.jpg" };
				var cat4 = new Cat { Id = "cat4", Name = "Baubles", ImageUrl = "https://s-media-cache-ak0.pinimg.com/736x/92/9d/3d/929d3d9f76f406b5ac6020323d2d32dc.jpg" };
				var cat5 = new Cat { Id = "cat5", Name = "Grumpy Cat", ImageUrl = "https://pbs.twimg.com/profile_images/378800000532546226/dbe5f0727b69487016ffd67a6689e75a.jpeg" };
				var cat6 = new Cat { Id = "cat6", Name = "Bigglesworth", ImageUrl = "http://www.cats.org.uk/uploads/images/featurebox_sidebar_kids/shop6.jpg" };
				var cat7 = new Cat { Id = "cat7", Name = "Snuffles", ImageUrl = "http://www.rd.com/wp-content/uploads/sites/2/2016/02/12-13-things-you-didnt-know-about-cats-no-chocolate.jpg" };
				var cat8 = new Cat { Id = "cat8", Name = "Fatcat", ImageUrl = "https://s-media-cache-ak0.pinimg.com/736x/35/8c/57/358c57c204a2fec21fa50b917a0728aa.jpg" };

				cats.Add(cat1);
				cats.Add(cat2);
				cats.Add(cat3);
				cats.Add(cat4);
				cats.Add(cat5);
				cats.Add(cat6);
				cats.Add(cat7);
				cats.Add(cat8);

				_realmService.AddOrUpdate(cats);
			}
		}

		public IRealmCollection<Cat> GetCats()
		{
			var query = _realmService.QueryAll<Cat>();

			return query.AsRealmCollection();
		}
	}
}
