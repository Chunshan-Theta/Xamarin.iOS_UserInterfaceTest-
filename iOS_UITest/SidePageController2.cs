using Foundation;
using System;
using System.Linq;
using UIKit;

namespace iOS_UITest
{
    public partial class SidePageController2 : UIPageViewController
    {
        public SidePageController2 (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {

            base.ViewDidLoad();


            SidePageDataSource dataSource = new SidePageDataSource();

            DataSource = dataSource;
            SetViewControllers(new[] { dataSource.Pages.ElementAt(0) }, UIPageViewControllerNavigationDirection.Forward, true, null);


        }
    }
}