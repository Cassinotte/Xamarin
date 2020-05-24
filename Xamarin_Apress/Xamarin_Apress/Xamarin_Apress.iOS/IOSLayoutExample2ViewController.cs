using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace Xamarin_Apress.iOS
{
    [Register("UniversalView")]
    public class UniversalView : UIView
    {
        public UniversalView()
        {
            Initialize();
        }

        public UniversalView(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.Red;
        }
    }

    [Register("IOSLayoutExample2ViewController")]
    public class IOSLayoutExample2ViewController : UIViewController
    {
        public IOSLayoutExample2ViewController()
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
            var textView = new UITextField
            {
                Placeholder = "Your name",
                BorderStyle = UITextBorderStyle.RoundedRect
            };

            textView.TranslatesAutoresizingMaskIntoConstraints = false;


            textView.AddConstraints(new[] {
                NSLayoutConstraint.Create(textView, NSLayoutAttribute.Height,
                    NSLayoutRelation.Equal, null, NSLayoutAttribute.NoAttribute,
                    1, 50),

                NSLayoutConstraint.Create(textView, NSLayoutAttribute.Width,
                    NSLayoutRelation.Equal, null, NSLayoutAttribute.NoAttribute,
                    1, 200)
                });

            View.AddConstraints(new[] {
                NSLayoutConstraint.Create(textView, NSLayoutAttribute.Left,
                    NSLayoutRelation.Equal, View, NSLayoutAttribute.Left,
                    1, 10),

                NSLayoutConstraint.Create(textView, NSLayoutAttribute.Top,
                    NSLayoutRelation.Equal, View, NSLayoutAttribute.Top,
                    1, 30)
                });

            Add(textView);
        }
    }
}