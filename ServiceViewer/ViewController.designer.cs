// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ServiceViewer
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTableView ApplicationsView { get; set; }

		[Outlet]
		AppKit.NSButton RefreshButton { get; set; }

		[Outlet]
		AppKit.NSButton ShutDownButton { get; set; }

		[Action ("ApplicationsViewOnAction:")]
		partial void ApplicationsViewOnAction (Foundation.NSObject sender);

		[Action ("RefreshButtonClick:")]
		partial void RefreshButtonClick (Foundation.NSObject sender);

		[Action ("ShutDownButtonClick:")]
		partial void ShutDownButtonClick (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (RefreshButton != null) {
				RefreshButton.Dispose ();
				RefreshButton = null;
			}

			if (ShutDownButton != null) {
				ShutDownButton.Dispose ();
				ShutDownButton = null;
			}

			if (ApplicationsView != null) {
				ApplicationsView.Dispose ();
				ApplicationsView = null;
			}
		}
	}
}
