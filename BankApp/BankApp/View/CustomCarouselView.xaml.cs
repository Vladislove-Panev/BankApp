using BankApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomCarouselView : CarouselView
    {
        public CustomCarouselView()
        {
            InitializeComponent();
            BindingContext = new CustomCarouselViewViewModel();
        }
    }
}