using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin_Apress_CustomRenderer;

[assembly: ExportRenderer(typeof(CustomButton), typeof(Xamarin_Apress_CustomRenderer.Droid.CustomButtonRenderer))]
namespace Xamarin_Apress_CustomRenderer.Droid
{
	public class CustomButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.SetBackgroundColor(global::Android.Graphics.Color.Chocolate);
			}
		}
	}
}