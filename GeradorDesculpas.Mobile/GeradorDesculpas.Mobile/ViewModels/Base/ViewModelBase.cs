using Prism.Mvvm;
using Prism.Navigation;

namespace GeradorDesculpas.Mobile.ViewModels.Base
{
    public class ViewModelBase : BindableBase, IDestructible
    {
        protected INavigationService NavigationService { get; }

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void Destroy()
        {

        }
    }
}