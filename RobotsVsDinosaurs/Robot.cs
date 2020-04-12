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
            //RobotType = robotType;
            //RobotHealth = robotHealth;
            //RobotPower = robotPower;
            AssignedWeapon = new Weapon();
            AssignedWeapon.AssignWeapon(RobotType);
        }

        

        
        


        //methods
        
        

    }
}
