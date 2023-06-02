using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USW_Pathfinder.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace USW_Pathfinder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Glyntaff : ContentPage
    {


        private Entry _entry;
        private Picker _picker;

        public Glyntaff()
        {
            InitializeComponent();
            InitializeComponent();

            List<Campus> buildings = new List<Campus>();

            buildings.Add(new Campus() { CampusID = 1, CampusName = "Cardiff" });
            buildings.Add(new Campus() { CampusID = 2, CampusName = "Treforest" });
            buildings.Add(new Campus() { CampusID = 3, CampusName = "Glyntaff" });
            buildings.Add(new Campus() { CampusID = 4, CampusName = "newport" });


            _entry = new Entry();
            _entry.Keyboard = Keyboard.Text;
            _entry.Placeholder = "picker Selected Value";
            _entry.IsVisible = false;


            _picker = new Picker();
            _picker.Title = "Select a campus";
            _picker.ItemsSource = buildings;


        }

        void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            // Handle the pinch
        }

        private void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            Models.Grid grid = new Models.Grid(20, 10, 10f);
        }
    }
}