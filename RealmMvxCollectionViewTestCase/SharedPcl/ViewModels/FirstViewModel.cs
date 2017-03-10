using MvvmCross.Core.ViewModels;
using Realms;
using SharedPcl.DataModels;
using SharedPcl.Services;

namespace SharedPcl.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
		private readonly ICatService _catService;

		public FirstViewModel(ICatService catService)
		{
			_catService = catService;

			_catService.CreateCats();
		}

		private IRealmCollection<Cat> _cats;
		public IRealmCollection<Cat> Cats
		{
			get { return _cats; }
		}

		public void GetCats()
		{
			_cats = _catService.GetCats();
		}
    }
}
