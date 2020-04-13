using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {

        //member variables
        
        public List<Robot> robotList;

        public Fleet()
        {

        }


        public List<Robot> PullRobots()
        {
            robotList = new List<Robot>
            {
                new Robot {RobotType = "Humanoid", RobotHealth = 30, RobotPower = 100, AssignedWeapon = new Weapon("Humanoid")},
                new Robot {RobotType = "Nightcrawler", RobotHealth = 25, RobotPower = 100, AssignedWeapon = new Weapon("Nightcrawler")},
                new Robot {RobotType = "Destroyer", RobotHealth = 35, RobotPower = 100, AssignedWeapon = new Weapon("Destroyer")},

            };

            return robotList;
           


            
            



        }
        


    }
}
