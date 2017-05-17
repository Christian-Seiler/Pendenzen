using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pendenzen;

namespace PendenzenTests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void getIDTest()
        {
            var actual = Person.getID();
            var expected = "sec";
            Assert.AreEqual(actual, expected);
        }
    }
}