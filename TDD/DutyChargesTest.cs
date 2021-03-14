using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityBillAPI.BusinessLogic;
using ElectricityBillAPI.Model;
using NUnit.Framework;

namespace ElectricityBillAPI.TDD
{
    public class DutyChargesTest
    {
        #region "Duty Charges"

        [Test]
        public void ShouldReturnDutyChargesWhenUnitsConsumedIsZero()
        {
            DutyCharges dutycharges = new DutyCharges();

            DutyChargesBilled result = dutycharges.DutyChargesCalculation(0);
            double actual = result.totaldutycharges;
            double expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldReturnDutyChargesWhenUnitsConsumedIsOneForSlab1()
        {
            DutyCharges dutycharges = new DutyCharges();
            int unit = 1;
            DutyChargesBilled result = dutycharges.DutyChargesCalculation(unit);
            double actual = result.totaldutycharges;
            double expected = 0.102;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ShouldReturnDutyChargesWhenUnitsConsumedForSlab1()
        {
            DutyCharges dutycharges = new DutyCharges();
            int unit = 40;
            DutyChargesBilled result = dutycharges.DutyChargesCalculation(unit);
            double actual = result.totaldutycharges;
            double expected = 4.068;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldReturnDutyChargesWhenUnitsConsumedForSlab2()
        {
            DutyCharges dutycharges = new DutyCharges();
            int unit = 95;
            DutyChargesBilled result = dutycharges.DutyChargesCalculation(unit);
            double actual = result.totaldutycharges;
            double expected = 11.187;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldReturnDutyChargesWhenUnitsConsumedForSlab3()
        {
            DutyCharges dutycharges = new DutyCharges();
            int unit = 250;
            DutyChargesBilled result = dutycharges.DutyChargesCalculation(unit);
            double actual = result.totaldutycharges;
            double expected = 32.205;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldReturnDutyChargesWhenUnitsConsumedForSlab4()
        {
            DutyCharges dutycharges = new DutyCharges();
            int unit = 700;
            DutyChargesBilled result = dutycharges.DutyChargesCalculation(unit);
            double actual = result.totaldutycharges;
            double expected = 93.225;
            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}
