using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Navigation;

namespace PrismAppSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase, INavigationAware
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}
