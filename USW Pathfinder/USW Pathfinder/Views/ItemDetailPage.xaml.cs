using System.ComponentModel;
using Xamarin.Forms;
using USW_Pathfinder.ViewModels;

namespace USW_Pathfinder.Views
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