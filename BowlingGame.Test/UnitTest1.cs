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
            // Test si toutes les quilles sont tomb�es OK

            int nbquilleInit = 10;
            int nbquillesDown = 10;

            // Assert
            Assert.AreEqual(nbquilleInit, nbquillesDown, 0.001, "Il reste des quilles � faire tomber");
        }

        [TestMethod]
        public void TestLancerFaitUnStrike()
        {
            // Test si toutes les quilles sont tomb�es KO

            Random aleatoire = new Random();

            int nbquilleInit = 10;
            int nbQuillesRestantes = 10;

            // G�n�re un nombre al�atoire de quilles d�gomm�es
            int nbQuillesJustDown = aleatoire.Next(1, nbQuillesRestantes+1);

            nbQuillesRestantes -= nbQuillesJustDown;

            // Assert
            Assert.AreEqual(0, nbQuillesRestantes, 0.001, "Vous n'avez pas fait de strike !!!");
        }

        [TestMethod]
        public void TestLancerFaitUnSpare()
        {
            // Test si toutes les quilles sont tomb�es KO

            Random aleatoire = new Random();

            int nbquilleInit = 10;
            int nbQuillesRestantes = 10;

            // G�n�re un nombre al�atoire de quilles d�gomm�es
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

            int nbLanc�sFaits = 10;
            int nbLanc�sAFaire = 10;

            // G�n�re un nombre al�atoire de quilles d�gomm�es
            nbLanc�sFaits = aleatoire.Next(0, nbLanc�sAFaire + 1);

            // Assert
            Assert.AreEqual(nbLanc�sAFaire, nbLanc�sFaits, 0.001, "Vous n'avez pas fini la partie !!!");
        }
    }
}