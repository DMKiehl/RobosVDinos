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
        //public Robot Humanoid = new Robot("Humanoid", 30, 100);
        //public Robot Nightcrawler = new Robot("Nightcrawler", 25, 100);
        //public Robot Destroyer = new Robot("Destroyer", 35, 100);



        public List<Robot> PullRobots()
        {
            List<Robot> robotList = new List<Robot>
            {
                new Robot {RobotType = "Humanoid", RobotHealth = 30, RobotPower = 100, AssignedWeapon = ??},
                new Robot {RobotType = "Nightcrawler", RobotHealth = 25, RobotPower = 100, AssignWeapon = ??},
                new Robot {RobotType = "Destroyer", RobotHealth = 35, RobotPower = 100, AssignedWeapon = ??},

            };

            return robotList;


        }

    }
}
