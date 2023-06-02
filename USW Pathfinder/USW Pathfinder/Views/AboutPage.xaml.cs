using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace USW_Pathfinder.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
                
            await Navigation.PushAsync(new Navigation());
        }

        private async void CampusSelectButton_OnClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new CampusSelect());
        }


        private void CoursesTapped(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.southwales.ac.uk/courses/", BrowserLaunchMode.SystemPreferred);
        }


        public void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

    }
}