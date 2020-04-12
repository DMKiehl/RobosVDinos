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
        public int AttackPower;
        





        //constructor
        public Weapon()
        {

        }


        public void AssignWeapon(string robotType)
        {

            switch (robotType)
            {
               case "Humanoid":
                   WeaponType = "Powerfists";
                   AttackPower = 5;
                   break;
                    

                case "Destroyer":
                     WeaponType = "Rocket";
                     AttackPower = 6;
                    break;
                    

                case "Nightwalker":
                    WeaponType = "Sword";
                    AttackPower = 4;
                    break;
                    

            }
            


        }
            


        //member methods

        
    }
}
