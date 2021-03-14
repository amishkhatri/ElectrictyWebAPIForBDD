using ElectricityBillAPI.BusinessLogic;
using ElectricityBillAPI.Model;
using NUnit.Framework;
using System;


namespace ElectricityBillAPI.TDD
{
    public class EnergyChargesTest
    {
        [SetUp]
        public void Setup()
        {

        }


        #region "Energy Charges"

        [Test]
        public void ShouldReturnEnergyChargesWhenUnitsConsumedIsZero()
        {
            EnergyCharges energycharges = new EnergyCharges();
            EnergyChargesBilled result = energycharges.EnergyChargesCalculation(0);
            double actual = result.TotalEnergyCharges;
            double expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldReturnEnergyChargesWhenUnitsConsumedIsOneForSlab1()
        {
            EnergyCharges energycharges = new EnergyCharges();
            EnergyChargesBilled result = energycharges.EnergyChargesCalculation(1);
            double actual = result.TotalEnergyCharges;
            double expected = 4.05;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldReturnEnergyChargesWhenUnitsConsumedForSlab1()
        {
            EnergyCharges energycharges = new EnergyCharges();
            EnergyChargesBilled result = energycharges.EnergyChargesCalculation(45);
            double actual = result.TotalEnergyCharges;
            double expected = 182.25;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldReturnEnergyChargesWhenUnitsConsumedForSlab2()
        {
            EnergyCharges energycharges = new EnergyCharges();
            EnergyChargesBilled result = energycharges.EnergyChargesCalculation(51);
            double actual = result.TotalEnergyCharges;
            double expected = 207.45;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldReturnEnergyChargesWhenUnitsConsumedForSlab3()
        {
            EnergyCharges energycharges = new EnergyCharges();
            EnergyChargesBilled result = energycharges.EnergyChargesCalculation(151);
            double actual = result.TotalEnergyCharges;
            double expected = 703.80;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldReturnEnergyChargesWhenUnitsConsumedForSlab4()
        {
            EnergyCharges energycharges = new EnergyCharges();
            EnergyChargesBilled result = energycharges.EnergyChargesCalculation(301);
            double actual = result.TotalEnergyCharges;
            double expected = 1649.00;
            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}