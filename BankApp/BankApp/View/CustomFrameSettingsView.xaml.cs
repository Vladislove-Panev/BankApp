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
    public partial class CustomFrameSettingsView : Frame
    {
        public CustomFrameSettingsView()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty LabelTextProperty = BindableProperty.Create(
            nameof(LabelText),
            typeof(string),
            typeof(CustomFrameSettingsView),
            default(string));

        public string LabelText
        {
            get => (string)GetValue(LabelTextProperty);
            set => SetValue(LabelTextProperty, value);
        }
    }
}