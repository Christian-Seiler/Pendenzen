using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendenzen
{
    class Departments
    {
        public static string[] getList()
        {
            List<String> list = new List<string>
            {
                "",
                "GL",
                "Einkauf",
                "Verkauf",
                "Buchhaltung",
                "Marketing",
                "Kursadministration",
                "Kursorganisation",
                "Personal",
                "Informatik"
            };

            return list.ToArray();
        }
    }
}
