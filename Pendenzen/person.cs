using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Security.Principal;

namespace Pendenzen
{
    public class Person
    {
        public static string getID()
        {
            if (Constants.VERSION == "DEBUG")
            {
                return "SEC";
            }
            return WindowsIdentity.GetCurrent().Name.Split('\\').Last();
        }

        public static List<string> getInfo()
        {
            return getInfo(getID());
        }
        
        public static List<string> getInfo(string id)
        {
            List<string> list = new List<string>();

            if (Constants.VERSION == "DEBUG")
            {
                list.Add(getID());
                list.Add(Constants.TESTERNAME);
                list.Add(Constants.TESTERSURNAME);
                list.Add(Constants.TESTERMAIL);
                list.Add(Constants.TESTERDEPARTMENT);
            } else
            {
                DirectoryEntry entry = new DirectoryEntry("LDAP://allpower.local", "intranet", "saarcos!50");
                DirectorySearcher search = new DirectorySearcher(entry);

                search.Filter = $"(&(objectClass=user)(samAccountName={id}))";
                search.SearchScope = SearchScope.Subtree;
                SearchResult result = search.FindOne();

                list.Add(result.Properties["samAccountName"][0].ToString());
                list.Add(result.Properties["givenName"][0].ToString());
                list.Add(result.Properties["sn"][0].ToString());
                list.Add(result.Properties["mail"][0].ToString());
                list.Add(result.Properties["distinguishedname"][0].ToString().Split(',')[1].Split('=').Last());
            }
            return list;
        }

        public static string username()
        {
            return getInfo()[0];
        }

        public static string username(string id)
        {
            return getInfo(id)[0];
        }

        public static string givenname()
        {
            return getInfo()[1];
        }

        public static string givenname(string id)
        {
            return getInfo(id)[1];
        }

        public static string familyname()
        {
            return getInfo()[2];
        }

        public static string familyname(string id)
        {
            return getInfo(id)[2];
        }

        public static string mail()
        {
            return getInfo()[3];
        }

        public static string mail(string id)
        {
            return getInfo(id)[3];
        }

        public static string department()
        {
            return getInfo()[4];
        }

        public static string department(string id)
        {
            return getInfo(id)[4];
        }

        public static bool isAdmin()
        {
            string deparetment = getInfo()[4];
            switch (deparetment)
            {
                case "Informatik":
                    return true;
                case "GL":
                    return true;
                default:
                    return false;
            }
        }
    }
}