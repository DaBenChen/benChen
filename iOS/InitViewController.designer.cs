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
	[Register ("InitViewController")]
	partial class InitViewController
	{
		[Outlet]
		UIKit.UILabel btnName { get; set; }

		[Outlet]
		UIKit.UIButton btnSend { get; set; }

		[Outlet]
		UIKit.UILabel lbMessage { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnName != null) {
				btnName.Dispose ();
				btnName = null;
			}

			if (btnSend != null) {
				btnSend.Dispose ();
				btnSend = null;
			}

			if (lbMessage != null) {
				lbMessage.Dispose ();
				lbMessage = null;
			}
		}
	}
}
