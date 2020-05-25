using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace Xamarin_DatePickerExampleIOS
{
    [Register("DatePickerExampleViewController")]
    public class DatePickerExampleViewController : UIViewController
    {
        public DatePickerExampleViewController()
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
            UIDatePicker datePicker = new UIDatePicker();
            datePicker.Mode = UIDatePickerMode.Date;
            datePicker.BackgroundColor = UIColor.White;

            datePicker.MinimumDate = (NSDate) DateTime.Today.AddDays(-7);
            datePicker.MaximumDate = (NSDate)DateTime.Today.AddDays(7);

            UIToolbar toolbar = new UIToolbar();
            toolbar.BarStyle = UIBarStyle.Default;
            toolbar.Translucent = true;
            toolbar.SizeToFit();
           
            UIBarButtonItem doneButton = new UIBarButtonItem("Done", UIBarButtonItemStyle.Done,
                    (s, e) =>
                    {
                        DateTime dateTime = DateTime.SpecifyKind((DateTime)datePicker.Date,
                            DateTimeKind.Unspecified);


                        datePicker.ResignFirstResponder();
                    });

            toolbar.SetItems(new UIBarButtonItem[] { doneButton }, true);

            // this.textField.InputAcessoryView = toolbar;
            datePicker.AddSubview(toolbar);
            this.Add(toolbar);

            //this.textField.InputView = picker;
            this.Add(datePicker);
        }
    }
}