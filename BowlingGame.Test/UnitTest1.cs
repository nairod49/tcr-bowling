using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestQuillesDown()
        {
            // Test si toutes les quilles sont tombées OK

            int nbquilleInit = 10;
            int nbquillesDown = 10;

            // Assert
            Assert.AreEqual(nbquilleInit, nbquillesDown, 0.001, "Il reste des quilles à faire tomber");
        }

        [TestMethod]
        public void TestLancerFaitUnStrike()
        {
            // Test si toutes les quilles sont tombées KO

            Random aleatoire = new Random();

            int nbquilleInit = 10;
            int nbQuillesRestantes = 10;

            // Génère un nombre aléatoire de quilles dégommées
            int nbQuillesJustDown = aleatoire.Next(1, nbQuillesRestantes+1);

            nbQuillesRestantes -= nbQuillesJustDown;

            // Assert
            Assert.AreEqual(0, nbQuillesRestantes, 0.001, "Vous n'avez pas fait de strike !!!");
        }

        [TestMethod]
        public void TestLancerFaitUnSpare()
        {
            // Test si toutes les quilles sont tombées KO

            Random aleatoire = new Random();

            int nbquilleInit = 10;
            int nbQuillesRestantes = 10;

            // Génère un nombre aléatoire de quilles dégommées
            int nbQuillesJustDown = aleatoire.Next(1, nbQuillesRestantes+1);

            nbQuillesRestantes -= nbQuillesJustDown;
            if (nbQuillesRestantes > 0)
            {
                int nbQuillesJustDown2 = aleatoire.Next(1, nbQuillesRestantes+1);

                nbQuillesRestantes -= nbQuillesJustDown2;
            }

            // Assert
            Assert.AreEqual(0, nbQuillesRestantes, 0.001, "Vous n'avez pas fait de spare !!!");
        }

        [TestMethod]
        public void TestFinDePartie()
        {
            // Test si la partie est finie

            Random aleatoire = new Random();

            int nbLancésFaits = 10;
            int nbLancésAFaire = 10;

            // Génère un nombre aléatoire de quilles dégommées
            nbLancésFaits = aleatoire.Next(0, nbLancésAFaire + 1);

            // Assert
            Assert.AreEqual(nbLancésAFaire, nbLancésFaits, 0.001, "Vous n'avez pas fini la partie !!!");
        }
    }
}