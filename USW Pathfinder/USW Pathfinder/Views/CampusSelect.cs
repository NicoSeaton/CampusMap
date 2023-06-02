using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USW_Pathfinder.Models;
using Xamarin.Forms;

namespace USW_Pathfinder.Views
{
    public class CampusSelect : ContentPage
    {

        private readonly Label _label;
        private readonly Label _label2;
        private readonly Label _label3;
        private readonly Label _label4;
        private readonly Label _label5;
        private Picker _picker;
        private Button _button;
        private Entry _entry;


        public CampusSelect()
        {
            this.Title = "Campus selection page";

            List<Campus> campuses = new List<Campus>();

            campuses.Add(new Campus() { CampusID = 1, CampusName = "Cardiff" });
            campuses.Add(new Campus() { CampusID = 2, CampusName = "Treforest" });
            campuses.Add(new Campus() { CampusID = 3, CampusName = "Glyntaff" });
            campuses.Add(new Campus() { CampusID = 4, CampusName = "newport" });




         //    < StackLayout BackgroundColor="{StaticResource Accent}" VerticalOptions="FillAndExpand" HorizontalOptions="Fill">
         //   <StackLayout Orientation="Horizontal" HorizontalOptions="Center" VerticalOptions="Center">
         //       <ContentView Padding="0,40,0,40" VerticalOptions="FillAndExpand">
         //           <Image Source="university_logo.png" VerticalOptions="Center" HeightRequest="64" />
         //       </ContentView>
         
       


            StackLayout stackLayout = new StackLayout();
            stackLayout.Padding = new Thickness(20, 40, 20, 40);
            stackLayout.Orientation = StackOrientation.Vertical;
            stackLayout.HorizontalOptions = LayoutOptions.Center;

          //  <ContentView Padding="0,40,0,40" VerticalOptions="FillAndExpand">

            var image = new Image
            {
                Source = "university_logo.png",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Fill,
                BackgroundColor = Color.FromHex("#C41E3C"),
                HeightRequest = 64
            };
            stackLayout.Children.Add(image);

     

           
            
            _label = new Label();
            _label.Text = "Welcome to the campus selection screen for the University of South Wales.";
            _label.FontSize = 20;
            stackLayout.Children.Add(_label);

            _picker = new Picker();
            _picker.Title = "Select a campus";
            _picker.ItemsSource = campuses;
            stackLayout.Children.Add(_picker);

            _button = new Button();

            _button.Text = "Go to campus";
            _button.Clicked += _button_Clicked;
            stackLayout.Children.Add(_button);

            _entry = new Entry();
            _entry.Keyboard = Keyboard.Text;
            _entry.Placeholder = "picker Selected Value";
            _entry.IsVisible = false;
            stackLayout.Children.Add(_entry);

            _label2 = new Label();
            _label2.Text = "After you have chosen a campus you will be redirected to a map of that campus.";
            _label2.FontSize = 20;
            stackLayout.Children.Add(_label2);

            _label3 = new Label();
            _label3.Text = "You can choose the building on campus you would like to be directed to from the dropdown list.";
            _label3.FontSize = 20;
            stackLayout.Children.Add(_label3);


            _label4 = new Label();
            _label4.Text = "Tap the find button to set the building you have chosen as your destination.";
            _label4.FontSize = 20;
            stackLayout.Children.Add(_label4);

            _label5 = new Label();
            _label5.Text = "Finally touch a location on the map to choose where you want directions from.";
            _label5.FontSize = 20;
            stackLayout.Children.Add(_label5);


            Content = stackLayout;
        }

        internal static Task PushAsync(Navigation navigation)
        {
            throw new NotImplementedException();
        }

        private async void _button_Clicked(object sender, EventArgs e)
        {

            if (_picker.SelectedItem != null)
            {
                _entry.Text = _picker.SelectedItem.ToString();
            }


            if (_entry.Text == "Treforest")
            {
                await Navigation.PushAsync(new Navigation());
            }
            if (_entry.Text == "Cardiff")
            {
                await Navigation.PushAsync(new Cardiff());
            }
            if (_entry.Text == "Glyntaff")
            {
                await Navigation.PushAsync(new Glyntaff());
            }
            if (_entry.Text == "newport")
            {
                await Navigation.PushAsync(new Newport());
            }
        }
    }
}