using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathHelper;
using System;

namespace MathHelperTest
{
    [TestClass]
    public class RandomValueTest
    {
        double[,] distributionLaw1 = new double[2, 4];
        RandomValue rv1; 
        double[,] distributionLaw2 = new double[2, 4];
        RandomValue rv2;
        double[,] distributionLaw3 = new double[2, 4];
        RandomValue rv3;

        [TestMethod]
        public void ExpectedValueTest()
        {
            FillDistributionLaws();
            Assert.AreEqual(23.8, Math.Round(rv1.ExpectedValue, 1));
            Assert.AreEqual(13.7, Math.Round(rv2.ExpectedValue, 1));
            Assert.AreEqual(37.2, Math.Round(rv3.ExpectedValue, 1));
        }
        [TestMethod]
        public void DispersionTest()
        {
            FillDistributionLaws();
            Assert.AreEqual(5.76, Math.Round(rv1.Dispersion, 2));
            Assert.AreEqual(3.81, Math.Round(rv2.Dispersion, 2));
            Assert.AreEqual(3.76, Math.Round(rv3.Dispersion, 2));
        }
        private void FillDistributionLaws()
        {
            distributionLaw1[0, 0] = 21;
            distributionLaw1[1, 0] = 0.3;
            distributionLaw1[0, 1] = 23;
            distributionLaw1[1, 1] = 0.3;
            distributionLaw1[0, 2] = 25;
            distributionLaw1[1, 2] = 0.1;
            distributionLaw1[0, 3] = 27;
            distributionLaw1[1, 3] = 0.3; 
            rv1 = new RandomValue(distributionLaw1);

            distributionLaw2[0, 0] = 11;
            distributionLaw2[1, 0] = 0.25;
            distributionLaw2[0, 1] = 13;
            distributionLaw2[1, 1] = 0.25;
            distributionLaw2[0, 2] = 14;
            distributionLaw2[1, 2] = 0.15;
            distributionLaw2[0, 3] = 16;
            distributionLaw2[1, 3] = 0.35;
            rv2 = new RandomValue(distributionLaw2);

            distributionLaw3[0, 0] = 34;
            distributionLaw3[1, 0] = 0.15;
            distributionLaw3[0, 1] = 36;
            distributionLaw3[1, 1] = 0.3;
            distributionLaw3[0, 2] = 38;
            distributionLaw3[1, 2] = 0.35;
            distributionLaw3[0, 3] = 40;
            distributionLaw3[1, 3] = 0.2;
            rv3 = new RandomValue(distributionLaw3);
        }
    }
}
