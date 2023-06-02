using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using USW_Pathfinder.Models;
using System.Collections.ObjectModel;

namespace USW_Pathfinder.ViewModels
{
    class AboutViewModel : BaseViewModel
    {

        public IList<Campus> CampList { get; set; }



        public AboutViewModel()
        {


            try
            {
                CampList = new ObservableCollection<Campus>
                {
                    new Campus { CampusID = 1, CampusName = "Cardiff" },
                    new Campus { CampusID = 2, CampusName = "Treforest" },
                    new Campus { CampusID = 3, CampusName = "Glyntaff" },
                    new Campus { CampusID = 4, CampusName = "Newport" }
                };

            }

            catch (Exception ex)
            {

            }





           //itle = "About";
           //penWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
        }
        
        //    CampusesList = GetCampuses().OrderBy(t => t.CampusName).ToList();

         // public ICommand OpenWebCommand { get; }
    }
             



}



   


        
       
        
        



