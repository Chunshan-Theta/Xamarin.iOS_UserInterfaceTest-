using Foundation;
using System;
using UIKit;

namespace iOS_UITest
{
    public partial class MainView : UIViewController
    {
        public MainView (IntPtr handle) : base (handle)
        {
        }



        partial void MoveToSecondPage_TouchUpInside(UIButton sender)
        {
            SecondPage Second = AppDelegate.MainStoryboard.InstantiateViewController("SecondPage") as SecondPage;
            Second.PageTitle = "THIS IS¡@A¡@STRING FROM HOME PAGE";
            AppDelegate.RootNavigationController.PushViewController(Second, true);
            
        }

        partial void MoveToSidePage_TouchUpInside(UIButton sender)
        {
            SidePageController Second = AppDelegate.MainStoryboard.InstantiateViewController("SidePageController") as SidePageController;
            
            AppDelegate.RootNavigationController.PushViewController(Second, true);
        }


        partial void MoveToSidePage2_TouchUpInside(UIButton sender)
        {
            SidePageController2 Second = AppDelegate.MainStoryboard.InstantiateViewController("SidePageController2") as SidePageController2;

            AppDelegate.RootNavigationController.PushViewController(Second, true);
        }

        partial void MoveToHUD_TouchUpInside(UIButton sender)
        {
            HUD Second = AppDelegate.MainStoryboard.InstantiateViewController("HUD") as HUD;

            AppDelegate.RootNavigationController.PushViewController(Second, true);
        }
    }
}