using System;
using System.Collections.Generic;

using Xamarin.Forms;
using GeradorDesculpas.Mobile.ViewModel;

namespace GeradorDesculpas.Mobile.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }
    }
}
