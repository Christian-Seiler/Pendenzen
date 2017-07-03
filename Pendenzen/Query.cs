using System;

namespace Pendenzen
{
    class Query
    {
        public static string admin()
        {
            if (!Person.isAdmin())
            {
                return $"AND department = '{Person.getInfo()[4]}'";
            }
            return "";
        }

        public static string admin(String modifier)
        {
            if (!Person.isAdmin())
            {
                return $"{modifier} department = '{Person.getInfo()[4]}'";
            }
            return "";
        }

        public static string department(string department)
        {
            if (Person.isAdmin() && department != "")
            {
                return $" AND department = '{department}'";
            }
            return "";
        }

        public static string department(String department, String modifier)
        {
            if (Person.isAdmin() && department != "")
            {
               return $" {modifier} department = '{department}'";
            }
            return "";
        }

        public static string ending(String order)
        {
            return $" ORDER BY idpendenz {order}";
        }
    }
}
