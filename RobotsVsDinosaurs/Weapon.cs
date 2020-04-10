using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {

        //member variables
        public string WeaponType;
        public int WeaponAttackPower;




        //constructor
        public Weapon(string weaponType, int attackPower)
        {

        }

            public Weapon sword = new Weapon("Sword", 2);
            public Weapon rocket = new Weapon("Rocket", 6);
            public Weapon powerFists = new Weapon("Power Fists", 4);
        


        //member methods

        
    }
}
