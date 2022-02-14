using Mobile.ViewModels;
using MobileCloudEaterApp.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileCloudEaterApp.Views
{
    public partial class VideoGamePage : ContentPage
    {
        public VideoGamePage()
        {
            InitializeComponent();
            BindingContext = new VideoGameViewModel();
        }
    }
}