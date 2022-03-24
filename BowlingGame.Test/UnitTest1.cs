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
            int nbQuillesJustDown = aleatoire.Next(1, nbQuillesRestantes);

            nbQuillesRestantes -= nbQuillesJustDown;

            // Assert
            Assert.AreEqual(0, nbQuillesRestantes, 0.001, "Vous n'avez pas fait de strike !!!");
        }
    }
}