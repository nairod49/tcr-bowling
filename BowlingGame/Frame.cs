using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    internal class Frame
    {
        private int nblancerFait;
        private int nbpoint;
        private int nbquille;

        public void frame()
        {
            this.nblancerFait = 0;
            this.nbpoint = 0;
            this.nbquille = 10;
        }

        public void lancer()
        {
            Random aleatoire = new Random();
            while (nblancerFait <= 2 || nbquille == 0)
            {
                int nbQuillesJustDown = aleatoire.Next(0,10-nbquille);
            }
        }

        public int get_nbpoint()
        {
            return this.nbpoint;
        }
        public int get_nbquille()
        {
            return this.nbquille;
        }

        public int get_nblancer()
        {
            return this.nblancerFait;
        }

        public void set_nblancer(int n)
        {
            this.nblancerFait = n;
        }

        public void set_nbpoint(int n)
        {
            this.nbpoint = n;
        }

        public void set_nbquille(int n)
        {
            this.nbquille = n;
        }


    }
}
