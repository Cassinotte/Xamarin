using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace Xamarin_StepperSliderSwitchIOS
{
    [Register("SelectionExample3ViewController")]
    public class SelectionExample3ViewController : UIViewController
    {
        public SelectionExample3ViewController()
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

			UILabel sliderLabel = new UILabel();
			Add(sliderLabel);

			UILabel stepperLabel = new UILabel();
			Add(stepperLabel);

			UILabel switchLabel = new UILabel();
			Add(switchLabel);

			UISlider slider = new UISlider();

			slider.MinValue = -1;
			slider.MaxValue = 2;
			slider.Value = 0.5f;
			slider.SetThumbImage(UIImage.FromBundle("thumb.png"), UIControlState.Normal);
			slider.ThumbTintColor = UIColor.Brown;
			slider.MinimumTrackTintColor = UIColor.LightGray;
			slider.MaximumTrackTintColor = UIColor.Green;
			slider.ValueChanged += (sender, e) => sliderLabel.Text = ((UISlider)sender).Value.ToString();

			Add(slider);

			UIStepper stepper = new UIStepper();

			stepper.MinimumValue = 0;
			stepper.MaximumValue = 11;
			stepper.StepValue = 2;
			stepper.ValueChanged += (object sender, EventArgs e) => stepperLabel.Text = stepper.Value.ToString();

			Add(stepper);

			UISwitch thisSwitch = new UISwitch();

			thisSwitch.On = false;
			thisSwitch.TintColor = UIColor.Blue;
			thisSwitch.OnTintColor = UIColor.Black;
			bool state = thisSwitch.On;
			thisSwitch.ValueChanged += (sender, e) => switchLabel.Text = thisSwitch.On.ToString();

		}
	}
}