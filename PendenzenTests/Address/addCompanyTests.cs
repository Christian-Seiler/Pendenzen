using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pendenzen;

namespace PendenzenTests
{
    [TestClass()]
    public class AddCompanyTests
    {
        [TestMethod()]
        public void addCompanyWithIDTest()
        {
            var id = "APW";
            var add = new addCompany(id);
        }
    }
}