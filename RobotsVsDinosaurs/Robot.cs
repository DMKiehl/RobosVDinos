using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        //member variables
        public string RobotType { get; set; }
        public int RobotHealth { get; set; }
        public int RobotPower { get; set; }
        public Weapon AssignedWeapon { get; set; }

        //constructor
        public Robot()
        {


        }
        

        
        


        //methods
        public void AttackDino(Dino dinoToAttack)
        {
            if (dinoToAttack.DinoHealth == 0)
            {
                Console.WriteLine("Dino is dead. Battle over!");
            }
            else
            {
                dinoToAttack.DinoHealth -= AssignedWeapon.AttackPower;
                Console.WriteLine("Dino Health is :" + dinoToAttack.DinoHealth);
            }
            

           
        }
        

    }
}
