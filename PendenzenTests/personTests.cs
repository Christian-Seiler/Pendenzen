using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pendenzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendenzenTests
{
    [TestClass()]
    public class personTests
    {
        [TestMethod()]
        public void getIDTest()
        {
            var actual = person.getID();
            var expected = "sec";
            Assert.AreEqual(actual, expected);
        }
    }
}