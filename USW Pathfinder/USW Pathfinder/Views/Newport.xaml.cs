using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace USW_Pathfinder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Newport : ContentPage
    {

        private Entry _entry;

        public Newport()
        {
            InitializeComponent();
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