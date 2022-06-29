using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Jeu1;

namespace Jeu2.TestUnits
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

                // Arrange
                Jeu jeu = new Jeu();

                // Act
                var resultat = jeu.Tour(6, 1);

                // Assert
                if (resultat != Resultat.Gagne)
                    Assert.Fail();
                if (jeu.Heros.Points != 1)
                    Assert.Fail();
                if (jeu.Heros.PointDeVies != 15)
                    Assert.Fail();
            }

            [TestMethod]
            public void TestMethod2()
            {
                // Arrange
                Jeu jeu = new Jeu();

                // Act
                var resultat = jeu.Tour(5, 5);

                // Assert
                if (resultat != Resultat.Gagne)
                    Assert.Fail();
                if (jeu.Heros.Points != 1)
                    Assert.Fail();
                if (jeu.Heros.PointDeVies != 15)
                    Assert.Fail();
            }

            [TestMethod]
            public void TestMethod3()
            {
                // Arrange
                Jeu jeu = new Jeu();

                // Act
                var resultat = jeu.Tour(2, 4);

                // Assert
                if (resultat != Resultat.Perdu)
                    Assert.Fail();
                if (jeu.Heros.Points != 0)
                    Assert.Fail();
                if (jeu.Heros.PointDeVies != 13)
                    Assert.Fail();
            }

    }
}

