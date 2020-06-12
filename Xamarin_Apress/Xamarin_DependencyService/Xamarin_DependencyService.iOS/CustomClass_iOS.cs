using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin_DependencyService.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(CustomClass_iOS))]
namespace Xamarin_DependencyService.iOS
{
	public class CustomClass_iOS : ICustomClass
	{
		public CustomClass_iOS() { }

		public string GoNative(string param)
		{
			return "iOS " + param;
		}
	}
}