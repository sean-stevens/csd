using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests
{
    [TestClass]
    public class ShieldTest
    {
        [TestMethod]
        public void ShieldsStartWithEnergy()
        {
            var s = new StarTrek.Shield();

            Assert.AreEqual(8000, s.EnergyLevel());
        }

        [TestMethod]
        public void ShieldsStartDown()
        {
            var s = new StarTrek.Shield();

            Assert.IsFalse(s.IsUp());
        }

        [TestMethod]
        public void ShieldsCanBeRaised()
        {
            var s = new StarTrek.Shield();
            s.Raise();

            Assert.IsTrue(s.IsUp());
        }
    }
}
