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
    public class addCompanyTests
    {
        [TestMethod()]
        public void addCompanyWithIDTest()
        {
            var id = "APW";
            var add = new addCompany(id);
        }
    }
}