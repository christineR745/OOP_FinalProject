using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create map and location objects
            WorldMap map = new WorldMap();
            Location combatArea1 = new Location("combatArea1", btn_combatArea1, 25);
            Location combatArea2 = new Location("combatArea2", btn_combatArea2, 50);
            Location combatArea3 = new Location("combatArea3", btn_combatArea3, 50);
            Location combatArea4 = new Location("combatArea4", btn_combatArea4, 100);
            Location shop = new Location("shop", btn_shop);
            map.Locations = new List<Location>{ combatArea1, combatArea2, combatArea3, combatArea4, shop };

            // create items
            Consumable potion = new Consumable("Potion", 1, 10);
            potion.Description = "Restores 10HP";
            Consumable xPotion = new Consumable("X Potion", 1, 20);
            xPotion.Description = "Restores 20HP";
            Consumable superPotion = new Consumable("Super Potion", 1, 50);
            superPotion.Description = "Restores 50HP";
            Consumable megaPotion = new Consumable("Mega Potion", 1, 50);
            megaPotion.Description = "Fully restores HP";
        }
    }
}
