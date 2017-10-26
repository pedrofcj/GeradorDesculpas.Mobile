using Android.Content;
using GeradorDesculpas.Mobile.Droid.Services;
using GeradorDesculpas.Mobile.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(ShareService))]
namespace GeradorDesculpas.Mobile.Droid.Services
{
    public class ShareService : IShareService
    {
        public void ShareText(string text)
        {
            var myIntent = new Intent(Intent.ActionSend);
            myIntent.SetType("text/plain");
            myIntent.PutExtra(Intent.ExtraText, text);
            Forms.Context.StartActivity(Intent.CreateChooser(myIntent, "Compartilhar"));
        }
    }
}