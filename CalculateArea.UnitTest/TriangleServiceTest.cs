using System;
using System.Collections.Generic;
using System.Text;
using CalculateArea.Figures.Kind;
using CalculateArea.InputModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateArea.UnitTest
{
    [TestClass]
    public class TriangleServiceTest
    {
        [TestMethod]
        public void Input_1_2_3_Expected_0()
        {
            var result   = new TriangleService<TriangleInput>(new TriangleInput(1,2,3)).GetArea();
            var expected = 0;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void Input_5_6_7_Expected_14_70()
        {
            var result   = new TriangleService<TriangleInput>(new TriangleInput(5, 6, 7)).GetArea();
            var expected = 14.7;
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void Input_3_4_5_Expected_true()
        {
            var result   = new TriangleService<TriangleInput>(new TriangleInput(3,4,5)).IsStraight();
            var expected = true;
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void Input_3_4_6_Expected_false()
        {
            var result   = new TriangleService<TriangleInput>(new TriangleInput(3, 4, 6)).IsStraight();
            var expected = false;
            Assert.AreEqual(result, expected);
        }
    }
}
