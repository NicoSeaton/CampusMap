using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.IO;
using System.Reflection;
using USW_Pathfinder.Resource;
using USW_Pathfinder.Models;


namespace USW_Pathfinder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navigation : ContentPage
    {


        private Entry _entry;

        public Navigation()
        {
            InitializeComponent();

        }

        private void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            Models.Grid grid = new Models.Grid(20, 10, 10f);
        }

        private void LoadButton_OnClicked(object sender, EventArgs e)
        { 

        }



        public void ReadButton_OnClicked(object sender, EventArgs e)
        {
           
        }

        void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            // Handle the pinch
        }

 
    }
}
      
