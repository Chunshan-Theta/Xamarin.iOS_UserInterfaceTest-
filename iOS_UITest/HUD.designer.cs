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
    [Register ("HUD")]
    partial class HUD
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton waitbu { get; set; }
        [Action ("UIButton96_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton96_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton95_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton95_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton99_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton99_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton101_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton101_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (waitbu != null) {
                waitbu.Dispose ();
                waitbu = null;
            }
        }
    }
}