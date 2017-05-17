using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Pendenzen;

namespace PendenzenTests
{
    [TestClass]
    public class PasswordTests
    {
        Encryption crypt = new Encryption();
        DBConnect db = new DBConnect();
        string query = "";

        [TestMethod]
        public void hasNewPasswordTest()
        {
        }

        [TestMethod]
        public void authenticateTest()
        {
            query = $"SELECT AdminOption FROM admin WHERE idadmin = 'pass'";
            var passTable = db.Select(query);
            var passRow = passTable.Rows[0];
            var passCell = passRow.ItemArray;
            var actual = passCell[0].ToString();

            var expected = crypt.encrypt("santis");
            Assert.AreEqual(expected, actual);
        }
    }
}