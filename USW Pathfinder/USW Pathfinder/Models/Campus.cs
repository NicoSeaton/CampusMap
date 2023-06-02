using System;
using System.Collections.Generic;
using System.Text;

namespace USW_Pathfinder.Models
{
    public class Campus
    {
        public int CampusID { get; set; }
        public string CampusName { get; set; }


     
        public override string ToString()
        {
            return this.CampusName;
        }


    }
}
