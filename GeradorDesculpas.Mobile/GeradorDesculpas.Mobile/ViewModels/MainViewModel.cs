using GeradorDesculpas.Mobile.Util;
using GeradorDesculpas.Mobile.ViewModels.Base;
using Plugin.Share;
using Prism.Navigation;
using Prism.Commands;

namespace GeradorDesculpas.Mobile.ViewModels
{
    public class MainViewModel : ViewModelBase, INavigationAware
    {
        public MainViewModel(INavigationService navigationService) : base(navigationService) {}

        #region Properties

        private string _desculpa;
        public string Desculpa
        {
            get => _desculpa;
            set => SetProperty(ref _desculpa, value);
        }

        #endregion

        #region Commands

        private DelegateCommand _gerarDesculpaCommand;
        public DelegateCommand GerarDesculpaCommand => _gerarDesculpaCommand ?? (_gerarDesculpaCommand = new DelegateCommand(() => Desculpa = Gerador.GerarDesculpa()));

        private DelegateCommand _compartilharCommand;
        public DelegateCommand CompartilharCommand =>_compartilharCommand ?? (_compartilharCommand = new DelegateCommand(ExecuteCompartilharCommand));
        private void ExecuteCompartilharCommand()
        {
            var msg = new Plugin.Share.Abstractions.ShareMessage
            {
                Text = Desculpa
            };

            CrossShare.Current.Share(msg);
        }

        #endregion

        #region INavigationAware

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            GerarDesculpaCommand.Execute();
        }

        #endregion

    }
}
