using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;
using CoreGraphics;

namespace iOS_UITest
{
    class SidePageDataSource : UIPageViewControllerDataSource
    {
        public List<UIViewController> Pages = new List<UIViewController>();
        
        public SidePageDataSource()
        {
            var redVC = new UIViewController();
            redVC.View.BackgroundColor = UIColor.Gray;
            AddData(redVC);
            Pages.Add(redVC);

            var blueVC = new UIViewController();
            blueVC.View.BackgroundColor = UIColor.White;
            AddData(blueVC);
            Pages.Add(blueVC);

            var yellowVC = new UIViewController();
            yellowVC.View.BackgroundColor = UIColor.Gray;
            AddData(yellowVC);
            Pages.Add(yellowVC);



        }

        public override UIViewController GetPreviousViewController(
            UIPageViewController pageViewController, UIViewController referenceViewController)
        {

            var index = Pages.IndexOf(referenceViewController) - 1;
            if (index < 0)
            {
                //index = (Pages.Count - 1);
                return null;
            }

            return Pages.ElementAt(index);

        }

        public override UIViewController GetNextViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
        {
            var index = Pages.IndexOf(referenceViewController) + 1;
            if (index >= Pages.Count)
            {
                //index = 0;
                return null;
            }

            return Pages.ElementAt(index);

        }

        public override nint GetPresentationCount(UIPageViewController pageViewController)
        {
            return Pages.Count;
        }

        public override nint GetPresentationIndex(UIPageViewController pageViewController)
        {

            return Pages.IndexOf(Pages.First());
            //return 0;
        }
        public void AddData(UIViewController v)
        {
            nfloat h = 31.0f;
            nfloat w = v.View.Bounds.Width;

            UILabel usernameField = new UILabel()
            {
                Text = "HI" ,
                Frame = new CGRect(10, 82, w - 20, h)
            };
            v.View.AddSubview(usernameField);

            h += 100f;
            usernameField = new UILabel()
            {
                Text = "wwwwwww" ,
                Frame = new CGRect(10, 82, w - 20, h)
            };




        }
    }
}