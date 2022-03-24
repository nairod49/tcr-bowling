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
            int nbQuillesJustDown = aleatoire.Next(1, nbQuillesRestantes);

            nbQuillesRestantes -= nbQuillesJustDown;

            // Assert
            Assert.AreEqual(0, nbQuillesRestantes, 0.001, "Vous n'avez pas fait de strike !!!");
        }
    }
}