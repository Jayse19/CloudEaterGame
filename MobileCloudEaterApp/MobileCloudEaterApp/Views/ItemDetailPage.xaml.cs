using MobileCloudEaterApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobileCloudEaterApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}