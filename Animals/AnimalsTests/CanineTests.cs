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
    public class CanineTests
    {
        Canine myCanine = new Canine();
        [TestMethod()]
        public void CanineTest()
        {
            Assert.AreEqual(4, myCanine.NumLegs);
            Assert.AreEqual("Canis", myCanine.Species);
            Assert.IsTrue(myCanine.HasFur);
            Assert.IsTrue(myCanine.HasTail);
            Assert.IsFalse(myCanine.HasOpposableThumb);
        }

        [TestMethod()]
        public void AdoptedTest()
        {
            Assert.IsNull(myCanine.Owner);
            Human frank = new Human();
            frank.FirstName = "Sam";
            myCanine.Adopted(frank);
            Assert.IsNotNull(myCanine.Owner);
            Assert.AreEqual("Sam", myCanine.Owner.FirstName);

        }

        [TestMethod()]
        public void AdoptedTest1()
        {
            Assert.IsNull(myCanine.DogName);
            Assert.IsNull(myCanine.Owner);
            Human HumanA = new Human();
            myCanine.DogName = "Tank";
            HumanA.FirstName = "Sandra";
            myCanine.Adopted(HumanA, myCanine.DogName);
            Assert.IsNotNull(myCanine.Owner);
            Assert.IsNotNull(myCanine.DogName);
            Assert.AreEqual("Sandra", myCanine.Owner.FirstName);
            Assert.AreEqual("Tank", myCanine.DogName);
        }
    }
}