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

            //foreach(Robot robot in robotList)
            //{
            //    Console.WriteLine(robot.RobotType + " " + robot.RobotHealth + " " + robot.RobotPower + " " + robot.AssignedWeapon);
               
                
                
            //}
            //Console.ReadLine();

            return robotList;
           


            
            



        }
        


    }
}
