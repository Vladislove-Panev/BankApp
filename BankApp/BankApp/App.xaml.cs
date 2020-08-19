using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            InitColors();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = StyleManager.GetAppResource<Color>("AppSecondBgColor");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = StyleManager.GetAppResource<Color>("AppMainColor");
        }

        private void InitColors()
        {
            Resources.MergedDictionaries.Add(new Palette());
            Resources.MergedDictionaries.Add(new Colors());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
