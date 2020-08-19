using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BankApp
{
    public class StyleManager
    {
        public static T GetAppResource<T>(string key)
        {
            return (T)Application.Current.Resources[key];
        }
    }
}
