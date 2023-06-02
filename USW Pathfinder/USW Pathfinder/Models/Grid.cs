using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Numerics;

namespace USW_Pathfinder.Models
{
    class Grid
    {
        private int height;
        private int width;
        private int[,] gridArray;
        private float cellsize;
       
        public Grid(int width, int height, float cellsize)
        {
            this.width = width;
            this.height = height;
            this.cellsize = cellsize;

            gridArray = new int[width, height];

            for (int x = 0; x < gridArray.GetLength(0); x++) 
            {
                for (int y = 0; y < gridArray.GetLength(1); y++)
                {

                }
            }
 
        }
        private Vector2 GetworldPosition(int x, int y)
        {
            return new Vector2 (x, y) * cellsize;
        }
    }
}
