using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin_Apress_CustomRenderer;

[assembly: ExportRenderer(typeof(CustomButton), typeof(Xamarin_Apress_CustomRenderer.iOS.CustomRenderer))]
namespace Xamarin_Apress_CustomRenderer.iOS
{
    public class CustomRenderer : ButtonRenderer
    {
        public CustomRenderer() : base()
        {
            if (Control != null)
            {
                Control.BackgroundColor = UIColor.Brown;
            }
        }
    }
}