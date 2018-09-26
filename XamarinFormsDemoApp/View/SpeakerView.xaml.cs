using System;
using System.Collections.Generic;
using XamarinFormsDemoApp.ViewModel;

using Xamarin.Forms;

namespace XamarinFormsDemoApp.View
{
    public partial class SpeakerView : ContentPage
    {

        SpeakerViewModel viewModel;

        public SpeakerView()
        {
            InitializeComponent();

            //if (Device.iOS == TargetPlatform.iOS)
            //    Padding = new Thickness(0, 20, 0, 0);
            //else if (Device.iOS == TargetPlatform.Android)
            //Padding = new Thickness(0, 0, 0, 0);

            //Padding = Device.OnPlatform<Thickness>(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(0, 0, 0, 0),
            //    WinPhone: new Thickness(30, 20, 0, 0)
            //);

            //Device.OnPlatform(
            //    iOS:() => {
            //        Padding = new Thickness(0, 20, 0, 0);
            //    }
            //);

            viewModel = new SpeakerViewModel();

            //listSpeakers.ItemsSource = viewModel.Speakers;
            BindingContext = viewModel;
        }
    }
}
