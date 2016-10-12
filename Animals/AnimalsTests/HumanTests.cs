using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Tests
{
    [TestClass()]
    public class HumanTests
    {
        Human myHuman = new Human();

        [TestMethod()]
        public void HumanTest()
        {
            myHuman.FirstName = "Philip";
            myHuman.LastName = "Jones";

            Assert.AreEqual("Philip", myHuman.FirstName);
            Assert.AreEqual("Jones", myHuman.LastName);
            Assert.AreEqual(2, myHuman.NumLegs);
            Assert.IsFalse(myHuman.HasFur);
            Assert.AreEqual("Homosapien", myHuman.Species);
            Assert.IsFalse(myHuman.HasTail);
            Assert.IsTrue(myHuman.HasOpposableThumb);
            Assert.AreEqual('S', myHuman.MaritalStatus);


        }

        [TestMethod()]
        public void GetMarriedTest()
        {
            myHuman.GetMarried();
            Assert.AreEqual('M', myHuman.MaritalStatus);
        }

        [TestMethod()]
        public void GetMarriedTest1()
        {
            myHuman.GetMarried("Fred", "Flinstone");
            Assert.AreEqual("Fred", myHuman.FirstName);
            Assert.AreEqual("Flinstone", myHuman.LastName);
            Assert.AreEqual('M', myHuman.MaritalStatus);
        }

        [TestMethod()]
        public void GetSingleTest()
        {
            myHuman.GetSingle();
            Assert.AreEqual('S', myHuman.MaritalStatus);

        }

        [TestMethod()]
        public void GetSingleTest1()
        {
            myHuman.GetSingle("Linda", "Savier");
            Assert.AreEqual('S', myHuman.MaritalStatus);
        }
    }
}