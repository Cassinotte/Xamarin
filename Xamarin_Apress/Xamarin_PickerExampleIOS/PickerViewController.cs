using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;
using System.Collections;
using System.Collections.Generic;
using CoreGraphics;

namespace Xamarin_PickerExampleIOS
{
    [Register("PickerViewController")]
    public class PickerViewController : UIViewController
    {
        public PickerViewController(IntPtr handle) : base(handle)
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
            string selectColor = "";

            PickerModel model = new PickerModel();
            model.ValuesChanged += (sender, e) =>
            {
                selectColor = model.SelectedItem;
            };

            UIPickerView picker = new UIPickerView();
            picker.ShowSelectionIndicator = true;
            picker.BackgroundColor = UIColor.White;
            picker.Model = model;


            //this.color.Text = model.SelectedItem;
            this.View.TintColor = new UIColor(new CGColor(model.SelectedItem));

            UIToolbar toolbar = new UIToolbar();
            toolbar.BarStyle = UIBarStyle.Default;
            toolbar.Translucent = true;
            toolbar.SizeToFit();

            UIBarButtonItem doneButton = new UIBarButtonItem("Done",
                UIBarButtonItemStyle.Done,
                (s, e) =>
                {
                    this.View.TintColor = new UIColor(new CGColor(selectColor));
                    this.View.ResignFirstResponder();
                    //this.color.ResignfirstResponder();
                });

            toolbar.SetItems(new UIBarButtonItem[] { doneButton }, true);

            //this.color.InputAcessoryView = toolbar;
            this.Add(toolbar);
            
            //this.color.InputView = picker;
            this.Add(picker);


        }
    }


    public class PickerModel: UIPickerViewModel
    {
        private readonly IList<string> items = new List<string>
        {
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Black"
        };

        public EventHandler<EventArgs> ValuesChanged;

        protected int selectedIndex = 0;

        public PickerModel()
        {

        }

        public string SelectedItem
        {
            get { return items[selectedIndex];  }
        }

        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return items.Count;
        }

        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            return items[(int)row];
        }

        public override nfloat GetRowHeight(UIPickerView pickerView, nint component)
        {
            return 40f;
        }

        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
            selectedIndex = (int)row;
            if (this.ValuesChanged != null)
            {
                this.ValuesChanged(this, new EventArgs());
            }
        }

    }
}