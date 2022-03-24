using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Frame
    {
        private int nblancerFait;
        private int nbpoint;
        private int nbquilleRestante;
        private int nbLancés;
        private int nbPointSpare;
        private bool spare;
        private bool strike;

        public  Frame(bool spare,bool strike)
        {
            this.spare = spare;
            this.strike = strike;
            this.nblancerFait = 0;
            this.nbpoint = 0;
            this.nbquilleRestante = 10;
            this.nbLancés = 0;
            
        }

        public void lancer()
        {
            Random aleatoire = new Random();
            while (nblancerFait <= 2 || nbquilleRestante > 0)
            {
                // Incrémente le nombre de lancés
                nbLancés++;
                // RAndom le nombre de quilles à faire tomber
                int nbQuillesJustDown = aleatoire.Next(0, nbquilleRestante + 1);
                // Si spear, ajouter les points double au score

                if (spare == true && nbLancés == 1)
                {
                    nbpoint = 2*nbQuillesJustDown;
                }// Si strike doublé le score des deux lancé
                else if (strike == true)
                {
                    nbpoint = 2 * nbQuillesJustDown;
                }
                else{
                    // Calcul le nombre de points
                    nbpoint += nbQuillesJustDown;
                }
               
            }
        }

        // Getters
        public int get_nbpoint()
        {
            return this.nbpoint;
        }
        public int get_nbquilleRestante()
        {
            return this.nbquilleRestante;
        }

        public int get_nblancer()
        {
            return this.nblancerFait;
        }

        public bool get_strike()
        {
            return this.strike;
        }

        public bool get_spare()
        {
            return this.spare;
        }
        // Setters
        public void set_nblancer(int n)
        {
            this.nblancerFait = n;
        }

        public void set_nbpoint(int n)
        {
            this.nbpoint = n;
        }

        public void set_nbquilleRestante(int n)
        {
            this.nbquilleRestante = n;
        }

        


    }
}
