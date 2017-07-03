using System;

namespace Pendenzen
{
    class Query
    {
        public static string Admin()
        {
            if (!Person.isAdmin())
            {
                return $"AND department = '{Person.getInfo()[4]}'";
            }
            return "";
        }

        public static string Admin(String modifier)
        {
            if (!Person.isAdmin())
            {
                return $"{modifier} department = '{Person.getInfo()[4]}'";
            }
            return "";
        }

        public static string Department(string department)
        {
            if (Person.isAdmin() && department != "")
            {
                return $" AND department = '{department}'";
            }
            return "";
        }

        public static string Department(String department, String modifier)
        {
            if (Person.isAdmin() && department != "")
            {
               return $" {modifier} department = '{department}'";
            }
            return "";
        }

        public static string Ending(String order)
        {
            return $" ORDER BY idpendenz {order}";
        }
    }
}
