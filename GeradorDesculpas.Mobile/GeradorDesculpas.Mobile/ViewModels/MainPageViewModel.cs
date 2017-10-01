using System.Windows.Input;
using GeradorDesculpas.Mobile.Util;
using Xamarin.Forms;

namespace GeradorDesculpas.Mobile.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        public BindableProperty DesculpaBindableProperty = BindableProperty.Create(nameof(Desculpa), typeof(string), typeof(string),
            Gerador.GerarDesculpa(), BindingMode.TwoWay);

        public string Desculpa
        {
            get => (string)GetValue(DesculpaBindableProperty);
            set => SetValue(DesculpaBindableProperty, value);
        }

        public ICommand GerarDesculpaCommand { get; set; }

        public ICommand CompartilharCommand { get; set; }

        public MainPageViewModel()
        {
            GerarDesculpaCommand = new Command(() => Desculpa = Gerador.GerarDesculpa());
            CompartilharCommand = new Command(() => App.ShareService.ShareText(Desculpa));
        }
    }
}