using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BankApp
{
    public class Colors : ResourceDictionary
    {
        public Colors()
        {
            Add("AppMainColor", (Color)Application.Current.Resources[Constants.Colors.Main]);
            Add("AppSecondBgColor", (Color)Application.Current.Resources[Constants.Colors.SecondBg]);
            Add("AppBlueColor", (Color)Application.Current.Resources[Constants.Colors.Blue]);
            Add("AppWhiteColor", (Color)Application.Current.Resources[Constants.Colors.White]);
            Add("AppGrayColor", (Color)Application.Current.Resources[Constants.Colors.Gray]);
            Add("AppIconsColor", (Color)Application.Current.Resources[Constants.Colors.IconsColor]);
        }
    }
}
