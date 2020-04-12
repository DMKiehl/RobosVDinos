using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {

        //member variables
        //public Dino Stegosaurus = new Dino("Stegosaurus", 35, 100, 4);
        //public Dino Triceratops = new Dino("Triceratops", 30, 100, 5);
        //public Dino Tyrannosaurus = new Dino("Tyrannosaurus", 40, 100, 7);





        public List<Dino> PullDinos()
        {
            List<Dino> dinoList = new List<Dino>
            {
                new Dino {DinoType = "Stegosaurus", DinoHealth = 35, DinoEnergy = 100, DinoAttackPower = 4},
                new Dino {DinoType = "Triceratops", DinoHealth = 30, DinoEnergy = 100, DinoAttackPower = 5},
                new Dino {DinoType = "Tyrannosaurus", DinoHealth = 40, DinoEnergy = 100, DinoAttackPower = 7},

            };

            return dinoList;


        }
        



    }
}
