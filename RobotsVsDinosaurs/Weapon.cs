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

            if (robotType == "Humanoid")
            {
                WeaponType = "Powerfists";
                AttackPower = 5;
                return; 
            }

            else if (robotType == "Destroyer")
            { 
                 WeaponType = "Rocket";
                 AttackPower = 6;
            }
            else
            {
                WeaponType = "Sword";
                AttackPower = 4;
            }
                    

                
                    
                    

        }
            


        
            


        //member methods

        
    }
}
