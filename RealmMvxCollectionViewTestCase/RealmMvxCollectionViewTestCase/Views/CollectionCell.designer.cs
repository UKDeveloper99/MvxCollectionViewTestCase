// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace RealmMvxCollectionViewTestCase
{
	[Register ("CollectionCell")]
	partial class CollectionCell
	{
		[Outlet]
		UIKit.UIImageView ImageViewCat { get; set; }

		[Outlet]
		UIKit.UILabel LabelName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ImageViewCat != null) {
				ImageViewCat.Dispose ();
				ImageViewCat = null;
			}

			if (LabelName != null) {
				LabelName.Dispose ();
				LabelName = null;
			}
		}
	}
}
