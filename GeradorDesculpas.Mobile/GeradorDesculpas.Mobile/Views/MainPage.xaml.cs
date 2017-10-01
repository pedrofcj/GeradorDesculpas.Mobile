using System;
using GeradorDesculpas.Mobile.Util;
using GeradorDesculpas.Mobile.ViewModels;
using Xamarin.Forms;

namespace GeradorDesculpas.Mobile.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }

    }
}
