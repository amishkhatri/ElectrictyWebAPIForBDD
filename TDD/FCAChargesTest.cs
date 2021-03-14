using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityBillAPI.BusinessLogic;
using ElectricityBillAPI.Model;
using NUnit.Framework;


namespace ElectricityBillAPI.TDD
{
    public class FCAChargesTest
    {
        #region "FCA Charges"

        [Test]
        public void ShouldReturnFCAChargesWhenUnitsConsumedForSlab1()
        {
            EnergyCharges FCACharges = new EnergyCharges();
            FCACharges.Units = 1;
            double result = FCACharges.FCACharges * FCACharges.Units;
            double expected = 0.13;
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void ShouldReturnFCAChargesWhenUnitsConsumedForSlab2()
        {
            EnergyCharges FCACharges = new EnergyCharges();
            FCACharges.Units = 51;
            double result = FCACharges.FCACharges * FCACharges.Units;
            double expected = 6.63;
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void ShouldReturnFCAChargesWhenUnitsConsumedForSlab3()
        {
            EnergyCharges FCACharges = new EnergyCharges();
            FCACharges.Units = 151;
            double result = FCACharges.FCACharges * FCACharges.Units;
            double expected = 19.63;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldReturnFCAChargesWhenUnitsConsumedForSlab4()
        {
            EnergyCharges FCACharges = new EnergyCharges();
            FCACharges.Units = 301;
            double result = FCACharges.FCACharges * FCACharges.Units;
            double expected = 39.13;
            Assert.AreEqual(expected, result);
        }

        #endregion
    }
}
