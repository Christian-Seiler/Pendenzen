using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pendenzen;
using System;

namespace PendenzenTests
{
    [TestClass()]
    public class PathTests
    {
        [TestMethod()]
        public void getPathTests()
        {
            bool inland = true;
            string department = "Einkauf";
            string company = "AAA";

            string expected = "";
            string country = "";

            switch (inland)
            {
                case true: country = "Inland"; break;
                case false: country = "Ausland"; break;
            }

            switch (department)
            {
                case "Einkauf": expected = $@"K:\{department}\Lieferanten\{country}\{company}\Korrespondenz"; break;
                case "Verkauf": expected = $@"K:\{department}\Kunden\{country}\{company}\Korrespondenz"; break;
                case "Buchhaltung": expected = $@"K:\{department}\Firmen\{country}\{company}"; break;
                default: expected = "-1"; break;
            }

            string actual = myPath.getPath(inland, company, department);
            Assert.AreEqual(expected, actual);
        }
    }
}