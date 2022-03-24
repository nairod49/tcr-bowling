using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    internal class Frame
    {
        private int nblancer;
        private int nbpoint;
        private int nbquille;

        public void frame(int lancer, int point,int quille)
        {
            this.nblancer = lancer;
            this.nbpoint = point;
            this.nbquille = quille;
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
            return this.nblancer;
        }

        public void set_nblancer(int n)
        {
            this.nblancer = n;
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
