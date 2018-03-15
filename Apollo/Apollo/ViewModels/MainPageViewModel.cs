using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apollo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { SetProperty(ref _nombre, value); }
        }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
            Nombre = "Hola Miguel";
        }
    }
}
