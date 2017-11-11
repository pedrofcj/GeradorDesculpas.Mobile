sing System;

using Xamarin.Forms;

namespace GeradorDesculpas.Mobile.Views
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

