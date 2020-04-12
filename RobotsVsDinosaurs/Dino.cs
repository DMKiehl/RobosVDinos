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
        public string DinoType;
        public int DinoHealth;
        public int DinoEnergy;
        public int DinoAttackPower;

        //construtor

        public Dino(string dinoType, int dinoHealth, int dinoEnergy, int dinoAttackPower)
        {
            DinoType = dinoType;
            DinoHealth = dinoHealth;
            DinoEnergy = dinoEnergy;
            DinoAttackPower = dinoAttackPower;

        }

        //member methods

    }
}
