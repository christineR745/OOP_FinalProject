using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FinalProject
{
    public class Item
    {
        public string Name;
        public string Description;
    }

    public class Equipable : Item 
    {
        public int Armor;
        public int Damage;
    
        public Equipable(string name, int armor = 0, int damage = 0)
        {
            Name = name;
            Armor = armor;
            Damage = damage;
        }
    }

    public class Consumable : Item 
    {
        public int Uses;
        public int Charge;
    
        public Consumable(string name, int uses = 0, int charge = 0)
        {
            Name = name;
            Uses = uses;
            Charge = charge;
        }
    
        public virtual void Effect() 
        {
            
        }
    }
}
