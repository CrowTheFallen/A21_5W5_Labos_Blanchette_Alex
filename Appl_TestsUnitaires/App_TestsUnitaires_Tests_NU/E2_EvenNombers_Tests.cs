using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appl_TestsUnitaires;

namespace App_TestsUnitaires_Tests_NU
{
    [TestFixture]
    public class E2_EvenNombers_Tests
    {
        private E2_EvenNumbers _evenNumbers;

        [Test]
        public void GetEvenNumbers_LimitIsGreaterThanZero_ReturnNumberUpToLimit()
        {
            // Arrange

            // Act 
            IEnumerable<int> result = _evenNumbers.GetEvenNumbers(6);

            // Assert
            Assert.That(result, Is.Not.Empty);

            Assert.That(result.Count(), Is.EqualTo(4));

            Assert.That(result, Does.Contain(0));
            Assert.That(result, Does.Contain(2));
            Assert.That(result, Does.Contain(4));
            Assert.That(result, Does.Contain(6));

            Assert.That(result, Is.EquivalentTo(new[] { 2, 0, 4, 6 }));

            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);


        }

        [SetUp]
        public void SetUp()
        {
            _evenNumbers = new E2_EvenNumbers();
        }

    }
}
