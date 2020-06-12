using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin_DependencyService.UWP;

[assembly: Xamarin.Forms.Dependency(typeof(CustomClass_WindowsPhone))]
namespace Xamarin_DependencyService.UWP
{
    public class CustomClass_WindowsPhone : ICustomClass
    {
        public CustomClass_WindowsPhone() { }

        public string GoNative(string param)
        {
            return "Windows Phone " + param;
        }
    }
}
