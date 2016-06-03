// WARNING
//
// This file has been generated automatically by Xamarin Studio Community to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace benChen.iOS
{
	[Register ("MenuViewController")]
	partial class MenuViewController
	{
		[Outlet]
		UIKit.UILabel lblNewPage { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblNewPage != null) {
				lblNewPage.Dispose ();
				lblNewPage = null;
			}
		}
	}
}
