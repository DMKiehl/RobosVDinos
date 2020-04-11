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
        public string RobotType;
        public int RobotHealth;
        public int RobotPower;
        public Weapon AssignedWeapon; 

        //constructor
        public Robot(string robotType, int robotHealth, int robotPower)
        {
            RobotType = robotType;
            RobotHealth = robotHealth;
            RobotPower = robotPower;
            AssignedWeapon = new Weapon();
            AssignedWeapon.AssignWeapon(robotType);
        }

        

        
        


        //methods
        
        

    }
}
