using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using SharedPcl.Services;
using UIKit;

namespace RealmMvxCollectionViewTestCase
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }
        
        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
			return new SharedPcl.App();
        }
        
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

		protected override void InitializeFirstChance()
		{
			base.InitializeFirstChance();

			Mvx.RegisterSingleton<IRealmService>(new RealmService("cats.realm"));
		}

		protected override void InitializeLastChance()
		{
			base.InitializeLastChance();

			Mvx.ConstructAndRegisterSingleton<ICatService, CatService>();
		}
    }
}
