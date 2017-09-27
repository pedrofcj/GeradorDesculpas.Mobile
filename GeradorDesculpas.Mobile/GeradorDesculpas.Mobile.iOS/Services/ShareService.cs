using GeradorDesculpas.Mobile.iOS.Services;
using GeradorDesculpas.Mobile.Services;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(ShareService))]
namespace GeradorDesculpas.Mobile.iOS.Services
{
    public class ShareService : IShareService
    {
        public void ShareText(string text)
        {
            var activityController = new UIActivityViewController(new[] { UIActivity.FromObject(text) }, null);
            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(activityController, true, null);
        }
    }
}