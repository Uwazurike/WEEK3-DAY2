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
    public class MammalTests
    {
        Mammal myMammal = new Mammal();
        [TestMethod()]
        public void MammalTest()
        {
            Assert.IsTrue(myMammal.GivesLiveBirth);
            Assert.AreEqual(0, myMammal.NumChildren);
        }

        [TestMethod()]
        public void GiveBirthTest()
        {
            myMammal.GiveBirth();
            Assert.IsTrue(myMammal.HasOffspring);
            Assert.AreEqual(1, myMammal.NumChildren);
        }

        [TestMethod()]
        public void GiveBirthTest1()
        {
            myMammal.GiveBirth(5);
            Assert.IsTrue(myMammal.HasOffspring);
            Assert.AreEqual(5, myMammal.NumChildren);

        }
    }
}