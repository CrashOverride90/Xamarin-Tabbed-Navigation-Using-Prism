using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Prism.Navigation;
using Prism.Common;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace PrismAppSample.Views
{
    public partial class MainPage : Xamarin.Forms.TabbedPage, INavigatingAware
    {
        public MainPage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            foreach (var child in Children)
            {
                PageUtilities.OnNavigatingTo(child, parameters);
            }
        }
    }
}