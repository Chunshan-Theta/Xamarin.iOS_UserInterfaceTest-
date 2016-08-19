using Foundation;
using System;
using UIKit;

namespace iOS_UITest
{
    public partial class SecondPage : UIViewController
    {
        public string PageTitle { get; set; }
        public SecondPage (IntPtr handle) : base (handle)
        {
            
        }
        public override void ViewDidLoad()
        {

            this.SecondPageTitle.Text = PageTitle;


        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

    }
}