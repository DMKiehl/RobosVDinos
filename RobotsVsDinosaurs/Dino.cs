using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dino
    {
        //member variables
        public string DinoType { get; set; }
        public int DinoHealth { get; set; }
        public int DinoEnergy { get; set; }
        public int DinoAttackPower { get; set; }

        //construtor

        public Dino()
        {
           // DinoType = dinoType;
            //DinoHealth = dinoHealth;
           // DinoEnergy = dinoEnergy;
           // DinoAttackPower = dinoAttackPower;

        }

        //member methods
        public void AttackRobot(Robot robotToAttack)
        {
            if (robotToAttack.RobotHealth <= 0)
            {
                Console.WriteLine("Robot is dead. Battle over!");
            }
            else
            {
                robotToAttack.RobotHealth -= DinoAttackPower;
                Console.WriteLine("Robot Health is :" + robotToAttack.RobotHealth);
            }
            

            
        }

    }
}
