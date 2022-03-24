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

        public void partie()
        {
            this.score_global = 0;
            this.nbframe = 0;
        }

        public void lancer_partie()
        {
            while (nbframe <= 10)
            {
               Frame frameactuel = new Frame(false, false);


            }

        }
    }
}
