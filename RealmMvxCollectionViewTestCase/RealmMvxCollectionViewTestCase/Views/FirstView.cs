// This file has been autogenerated from a class added in the UI designer.

using System;
using CoreGraphics;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.Platform;
using SharedPcl.MvvmCross;
using SharedPcl.ViewModels;
using UIKit;

namespace RealmMvxCollectionViewTestCase
{
	public partial class FirstView : MvxCollectionViewController<FirstViewModel>
	{
		public FirstView() : base("FirstView", null)
		{
        }

		public FirstView (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			Request = new MvxViewModelInstanceRequest(Mvx.IocConstruct<FirstViewModel>());
			base.ViewDidLoad();

			ViewModel.GetCats();

			// Use a copy of the MvvmCross collection view source so we can debug in project.
			var source = new MvxCollectionViewSourceCopy(CollectionView, new NSString("collectionCellId"));
			CollectionView.Source = source;
			(CollectionView.CollectionViewLayout as UICollectionViewFlowLayout).ItemSize = new CGSize(View.Frame.Width / 2, (View.Frame.Width / 2) + 25f);

			// Create binding set
			var set = this.CreateBindingSet<FirstView, FirstViewModel>();
			set.Bind(source).For(x => x.ItemsSource).To(vm => vm.Cats);
			set.Apply();   
		}
	}
}
