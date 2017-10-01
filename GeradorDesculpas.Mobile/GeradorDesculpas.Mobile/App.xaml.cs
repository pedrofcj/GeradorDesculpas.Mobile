using GeradorDesculpas.Mobile.Services;
using Xamarin.Forms;

namespace GeradorDesculpas.Mobile
{
    public partial class App
    {

        public static IShareService ShareService = DependencyService.Get<IShareService>();

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
