using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_FinalProject
{
    public class Location
    {
        public string Name;
        public Button Button;
        public List<Enemy> Enemies;
        public List<Item> ItemDrops;
        public int maxCoinDrop;

        public Location(string name, Button button, int coinDrop = 0) 
        { 
            Name = name;
            Button = button;
            maxCoinDrop = coinDrop;
        }

        public void LoadLocation()
        {
            // randomly choose enemies from list
            var random = new Random();
            int randInt = random.Next(Enemies.Count);
            Enemy randEnemy = Enemies[randInt];

            // combat method that automatically runs, using randEnemy

            // roll for random item drop, just made it 60% chance
            randInt = random.Next(10);
            if(randInt < 7)
            {
                randInt = random.Next(ItemDrops.Count);
                // put the item in player's item bag
            }

            // give player coins
            randInt = random.Next(maxCoinDrop);
            // add the result to player's coins
        }
    }
}
