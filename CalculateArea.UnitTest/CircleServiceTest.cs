using System.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateArea.Figures.Kind;
using CalculateArea.InputModels;

namespace CalculateArea.UnitTest
{
    [TestClass]
    public class CircleServiceTest
    {
        [TestMethod]
        public void Input_2_Expected_12_57()
        {
            var result   = new CircleService<CircleInput>(new CircleInput(2)).GetArea();
            var expected = 12.57;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void Input_10_Expected_314_16()
        {
            var result   = new CircleService<CircleInput>(new CircleInput(10)).GetArea();
            var expected = 314.16;
            Assert.AreEqual(result, expected);
        }
    }
}
