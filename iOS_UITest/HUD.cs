using Foundation;
using System;
using UIKit;
using BigTed;
using System.Threading.Tasks;

namespace iOS_UITest
{
    public partial class HUD : UIViewController
    {
        public HUD (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {

            base.ViewDidLoad();
            

        }


        //This method dismisses the activity after 1 second. You can provide your own images if needed - make them 28x28 white PNGs.
        partial void UIButton96_TouchUpInside(UIButton sender)
        {
            BTProgressHUD.ShowErrorWithStatus("Fail!");
        }

        partial void UIButton95_TouchUpInside(UIButton sender)
        {
            BTProgressHUD.ShowSuccessWithStatus("Wow, that worked");
        }
        
        partial void UIButton99_TouchUpInside(UIButton sender)
        {
            BTProgressHUD.ShowImage(UIImage.FromFile("icon2_ipad.png"), "Nice one Stu!");
            
        }

        partial void UIButton101_TouchUpInside(UIButton sender)
        {
            BTProgressHUD.Show();

        }
    }
}