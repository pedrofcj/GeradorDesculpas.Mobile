using System;
using GeradorDesculpas.Mobile.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GeradorDesculpas.Mobile
{
    public partial class App
    {

        public App(): this(null)
        {
            //InitializeComponent();
            //MainPage = new NavigationPage(new Views.MainPage());
        }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(new Uri("/NavigationPage/MainView", UriKind.Absolute));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainView>();
        }

    }
}