using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDesculpas.Mobile.Util;
using Xamarin.Forms;

namespace GeradorDesculpas.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnGerarDesculpa.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(GerarDesculpa)
            });

            GerarDesculpa();
        }

        private void GerarDesculpa()
        {
            lblDesculpa.Text = Gerador.GerarDesculpa();
        }

        protected override void OnAppearing()
        {
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            App.ShareService.ShareText(lblDesculpa.Text);
        }
    }
}
