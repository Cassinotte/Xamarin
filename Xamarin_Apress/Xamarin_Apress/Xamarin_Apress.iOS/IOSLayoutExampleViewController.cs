using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace Xamarin_Apress.iOS
{
    [Register("IOSLayoutExampleViewController")]
    public class IOSLayoutExampleViewController : UIViewController
    {
        public IOSLayoutExampleViewController()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view

            // Perform any additional setup after loading the view
            var textView = new UITextField
            {
                Placeholder = "Your name",
                BorderStyle = UITextBorderStyle.RoundedRect,
                Frame = new Rectangle(10,30,200,50)
            };

            Add(textView);
        }
    }
}