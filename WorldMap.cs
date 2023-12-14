using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FinalProject
{
    public class WorldMap
    {
        List<Location> Locations;

        public void DisplayMap()
        {
            // TODO:
            // load map image
            form.BackgroundImage = Properties.Resources.worldMap;
            form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            // display location buttons
            foreach(var location in Locations)
            {
                location.Button.Visible = true;
                location.Button.Enabled = true;
            }
        }
    }
}
