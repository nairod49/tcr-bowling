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
            while (nbframe <= 10)
            {
                // Lance une frame
               this.frameactuel.lancer();
                // Incrémente le nombre de frame réalisée
                nbframe++;

            }

        }
    }
}
