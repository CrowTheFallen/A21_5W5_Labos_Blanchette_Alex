using NUnit.Framework;
using Appl_TestsUnitaires;

namespace App_TestsUnitaires_Tests_NU
{
    public class E1_FizzBuzz_Tests
    {

        [Test]
        public void GetOutput_Duv3And5_ReturnFizzBuzz()
        {
            // Arrange
            var valeur = 15;
            // Act       
            var resultat = E1_FizzBuzz.GetOutput(valeur);
            // Assert
            Assert.That(resultat, Is.EqualTo(("FizzBuzz")));
        }

        [Test]
        public void GetOutput_Div3_ReturnFizz()
        {
            // Arrange
            var valeur = 9;
            // Act       
            var resultat = E1_FizzBuzz.GetOutput(valeur);
            // Assert
            Assert.That(resultat, Is.EqualTo(("Fizz")).IgnoreCase);
        }
        [Test]
        public void GetOutput_Div5_ReturnBuzz()
        {
            // Arrange
            var valeur = 10;
            // Act       
            var resultat = E1_FizzBuzz.GetOutput(valeur);
            // Assert
            Assert.That(resultat, Is.EqualTo(("Buzz")).IgnoreCase);
        }
        [Test]
        public void GetOutput_NonDiv3OrDiv5_ReturnParametre()
        {
            // Arrange
            var valeur = 7;
            // Act       
            var resultat = E1_FizzBuzz.GetOutput(valeur);
            // Assert
            Assert.That(resultat, Is.Not.EqualTo("Fizz"));
            Assert.That(resultat, Is.Not.EqualTo("Buzz"));
        }
    }
}