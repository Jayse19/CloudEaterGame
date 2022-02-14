using MobileCloudEaterApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileCloudEaterApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutoBots : ContentPage
    {
        public AutoBots()
        {
            InitializeComponent();
            BindingContext = new AutoBotsViewModel();
        }
    }
}