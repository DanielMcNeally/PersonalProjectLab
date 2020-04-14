using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;
namespace PersonalProjectLabTests
{
    [TestClass]
    public class DelatTTests
    {
        [TestMethod]
        public void CalculateDeltaT_CalculateBoilingPoint()
        {

            //arange
            MathDelataT mathDT = new MathDelataT();

            //act
            double myBoilingPoint = mathDT.CalculateKb(2, .1, 3.07);
            //asserting
            Assert.AreEqual(100.614, myBoilingPoint);
        }
        [TestMethod]
        public void CalculateDeltaT_CalculateFreezingPoint()
        {

            //arange
            MathDelataT mathDT = new MathDelataT();

            //act
            double myFreezingPoint = mathDT.CalculateKf(2, .1, 3.9);
            //asserting
            Assert.AreEqual(-0.78, myFreezingPoint);
        }
    }
}
