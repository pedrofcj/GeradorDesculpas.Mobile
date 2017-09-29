using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace GeradorDesculpas.Mobile.Droid
{
    [Activity(
        Theme = "@style/Theme.Splash",
        Icon = "@drawable/icon",
        Label = "Gerador de Desculpas",
        MainLauncher = true,
        NoHistory = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            RunOnUiThread(() =>
            {
                var mainActivity = new Intent(this, typeof(MainActivity));
                StartActivity(mainActivity);
                
            });
        }
    }
}