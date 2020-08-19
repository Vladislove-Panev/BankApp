using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomButton : ContentView
    {
        public CustomButton()
        {
            InitializeComponent();
        }

        public static new readonly BindableProperty BackgroundColorProperty = BindableProperty.Create(
            nameof(BackgroundColor),
            typeof(Color),
            typeof(CustomButton),
            default(Color)
            );

        public new Color BackgroundColor
        {
            get => (Color)GetValue(BackgroundColorProperty);
            set => SetValue(BackgroundColorProperty, value);
        }

        public static readonly BindableProperty ButtonCornerRadiusProperty = BindableProperty.Create(
            nameof(ButtonCornerRadius),
            typeof(double),
            typeof(CustomButton),
            default(double)
            );

        public double ButtonCornerRadius
        {
            get => (double)GetValue(ButtonCornerRadiusProperty);
            set => SetValue(ButtonCornerRadiusProperty, value);
        }

        public static readonly BindableProperty ButtonHeightRequestProperty = BindableProperty.Create(
            nameof(ButtonHeightRequest),
            typeof(double),
            typeof(CustomButton),
            default(double)
            );

        public double ButtonHeightRequest
        {
            get => (double)GetValue(ButtonHeightRequestProperty);
            set => SetValue(ButtonHeightRequestProperty, value);
        }

        public static readonly BindableProperty ButtonPaddingProperty = BindableProperty.Create(
            nameof(ButtonPadding),
            typeof(Thickness),
            typeof(CustomButton),
            new Thickness(0)
            );

        public Thickness ButtonPadding
        {
            get => (Thickness)GetValue(ButtonPaddingProperty);
            set => SetValue(ButtonPaddingProperty, value);
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(CustomButton),
            default(string)
            );

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly BindableProperty ColorProperty = BindableProperty.Create(
            nameof(Color),
            typeof(Color),
            typeof(CustomButton),
            default(Color)
            );

        public Color Color
        {
            get => (Color)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        public static readonly BindableProperty LabelVerticalTextAlignmentProperty = BindableProperty.Create(
            nameof(LabelVerticalTextAlignment),
            typeof(TextAlignment),
            typeof(CustomButton),
            TextAlignment.Center
            );

        public TextAlignment LabelVerticalTextAlignment
        {
            get => (TextAlignment)GetValue(LabelVerticalTextAlignmentProperty);
            set => SetValue(LabelVerticalTextAlignmentProperty, value);
        }

        public static readonly BindableProperty LabelHorizontalTextAlignmentProperty = BindableProperty.Create(
            nameof(LabelHorizontalTextAlignment),
            typeof(TextAlignment),
            typeof(CustomButton),
            TextAlignment.Center
            );

        public TextAlignment LabelHorizontalTextAlignment
        {
            get => (TextAlignment)GetValue(LabelHorizontalTextAlignmentProperty);
            set => SetValue(LabelHorizontalTextAlignmentProperty, value);
        }

        public static readonly BindableProperty TextFontSizeProperty = BindableProperty.Create(
            nameof(TextFontSize),
            typeof(double),
            typeof(CustomButton),
            default(double)
            );

        public double TextFontSize
        {
            get => (double)GetValue(TextFontSizeProperty);
            set => SetValue(TextFontSizeProperty, value);
        }
    }
}