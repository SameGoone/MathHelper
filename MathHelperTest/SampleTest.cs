using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathHelper;
using System;

namespace MathHelperTest
{
    [TestClass]
    public class SampleTest
    {
        double[,] distributionLaw1 = new double[2, 3];
        Sample sample1;
        double[,] distributionLaw2 = new double[2, 4];
        Sample sample2;
        double[,] distributionLaw3 = new double[2, 4];
        Sample sample3;

        [TestMethod]
        public void MeanTest()
        {
            FillDistributionLaws();
            Assert.AreEqual(1.9, Math.Round(sample1.Mean, 1));
            Assert.AreEqual(2.1, Math.Round(sample2.Mean, 1));
            Assert.AreEqual(2, Math.Round(sample3.Mean, 1));
        }
        [TestMethod]
        public void DispersionTest()
        {
            FillDistributionLaws();
            Assert.AreEqual(0.69, Math.Round(sample1.Dispersion, 2));
            Assert.AreEqual(0.69, Math.Round(sample2.Dispersion, 2));
            Assert.AreEqual(0.6, Math.Round(sample3.Dispersion, 1));
        }
        [TestMethod]
        public void ExactleDispersionTest()
        {
            FillDistributionLaws();
            Assert.AreEqual(0.767, Math.Round(sample1.ExactleDispersion, 3));
            Assert.AreEqual(0.767, Math.Round(sample2.ExactleDispersion, 3));
            Assert.AreEqual(0.667, Math.Round(sample3.ExactleDispersion, 3));
        }
        private void FillDistributionLaws()
        {
            distributionLaw1[0, 0] = 1;
            distributionLaw1[1, 0] = 4;
            distributionLaw1[0, 1] = 2;
            distributionLaw1[1, 1] = 3;
            distributionLaw1[0, 2] = 3;
            distributionLaw1[1, 2] = 3;
            sample1 = new Sample(distributionLaw1);

            distributionLaw2[0, 0] = 1;
            distributionLaw2[1, 0] = 3;
            distributionLaw2[0, 1] = 2;
            distributionLaw2[1, 1] = 3;
            distributionLaw2[0, 2] = 3;
            distributionLaw2[1, 2] = 4;
            sample2 = new Sample(distributionLaw2);

            distributionLaw3[0, 0] = 1;
            distributionLaw3[1, 0] = 3;
            distributionLaw3[0, 1] = 2;
            distributionLaw3[1, 1] = 4;
            distributionLaw3[0, 2] = 3;
            distributionLaw3[1, 2] = 3;
            sample3 = new Sample(distributionLaw3);
        }
    }
}
