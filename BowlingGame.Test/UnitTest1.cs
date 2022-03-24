using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;
namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestQuillesDown()
        {
            Frame frame = new Frame(false, false);
            // Test si toutes les quilles sont tombées OK

           frame.lancer();

            // Assert
            Assert.AreNotEqual(0, frame.get_nbpoint(), 0.001, "Il reste des quilles à faire tomber");
        }

        [TestMethod]
        public void TestLancerFaitUnStrike()
        {
            // Test si toutes les quilles sont tombées KO
            Frame frame = new Frame(false, true);
           
            frame.lancer();


            // Assert
            Assert.AreNotEqual(10-frame.get_nbquilleRestante(),frame.get_nbpoint(), 0.001, "Vous n'avez pas fait de strike !!!");
        }

        [TestMethod]
        public void TestLancerFaitUnSpare()
        {
            // Test si toutes les quilles sont tombées KO
            Frame frame = new Frame(true, false);

            frame.lancer();


            // Assert
            Assert.AreNotEqual(10 - frame.get_nbquilleRestante(), frame.get_nbpoint(), 0.001, "Vous n'avez pas fait de strike !!!");
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