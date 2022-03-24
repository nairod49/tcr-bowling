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
        private int nbquilleRestante;
        private int nbLancés;
        private int nbPointSpare;

        public void frame()
        {
            this.nblancerFait = 0;
            this.nbpoint = 0;
            this.nbquilleRestante = 10;
            this.nbLancés = 0;
            this.nbPointSpare = 0;
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
                // Mémorise le nombre de quilles tombées pour le cas ou l'on fait un spear
                nbPointSpare = nbQuillesJustDown;
                // Calcul le nombre de points
                nbpoint += nbQuillesJustDown;
                // Si spear, ajouter les points bonus "nbPointSpare"
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
