using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BowlingGame
{
    public class Partie
    {
        private int score_global;
        private int nbframe;
        private Frame frameactuel;

        public void partie()
        {
            this.score_global = 0;
            this.nbframe = 0;
            Frame frameactuel = new Frame(false, false);
        }

        public void lancer_partie()
        {
            bool strikeancien = false;
            bool spareancien = false;
            while (nbframe <= 10)
            {   this.frameactuel.set_strike(strikeancien);
                this.frameactuel.set_spare(spareancien);
                // Lance une frame
               this.frameactuel.lancer();
               score_global = score_global + this.frameactuel.get_nbpoint();
               strikeancien = this.frameactuel.get_strike();
               spareancien = this.frameactuel.get_spare();
                // Incrémente le nombre de frame réalisée
                nbframe++;

            }

            

        }
    }
}
