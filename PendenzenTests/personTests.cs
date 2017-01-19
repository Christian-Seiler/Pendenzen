using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pendenzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendenzen.Tests
{
    [TestClass()]
    public class personTests
    {
        [TestMethod()]
        public void getIDTest()
        {
            var ida = person.getID();
            var ide = "sec";
            Assert.AreEqual(ida, ide);
        }
    }
}