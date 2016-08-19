// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOS_UITest
{
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MoveToHUD { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MoveToSecondPage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MoveToSidePage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MoveToSidePage2 { get; set; }


        [Action ("MoveToSidePage_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void MoveToSidePage_TouchUpInside (UIKit.UIButton sender);

        [Action ("MoveToSecondPage_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void MoveToSecondPage_TouchUpInside (UIKit.UIButton sender);

        [Action ("MoveToSidePage2_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void MoveToSidePage2_TouchUpInside (UIKit.UIButton sender);

        [Action("MoveToHUD_TouchUpInside:")]
        [GeneratedCode("iOS Designer", "1.0")]
        partial void MoveToHUD_TouchUpInside(UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (MoveToHUD != null) {
                MoveToHUD.Dispose ();
                MoveToHUD = null;
            }

            if (MoveToSecondPage != null) {
                MoveToSecondPage.Dispose ();
                MoveToSecondPage = null;
            }

            if (MoveToSidePage != null) {
                MoveToSidePage.Dispose ();
                MoveToSidePage = null;
            }

            if (MoveToSidePage2 != null) {
                MoveToSidePage2.Dispose ();
                MoveToSidePage2 = null;
            }
        }
    }
}