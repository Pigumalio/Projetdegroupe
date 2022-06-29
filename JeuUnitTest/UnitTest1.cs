using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jeu2.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Jeu jeu=new Jeu();


            //Act
            var resultat = jeu.Tour(6, 1);

            //Assert
            if (resultat != Resultat.Gagne)
                Assert.Fail();
            if(jeu.Heros.Points!=1)
                Assert.Fail();
            if(jeu.Heros.PointDeVies!=15)
                Assert.Fail();
        }
    }
}
