using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Security.Principal;
using Microsoft.Win32;

namespace Pendenzen
{
    public class person
    {
        public static string getID()
        {
            return WindowsIdentity.GetCurrent().Name.Split('\\').Last();
        }

        public static List<string> getInfo()
        {
            return getInfo(getID());
        }



        public static List<string> getInfo(string id)
        {
            DirectoryEntry entry = new DirectoryEntry("LDAP://allpower.local", "intranet", "saarcos!50");
            DirectorySearcher search = new DirectorySearcher(entry);

            search.Filter = $"(&(objectClass=user)(samAccountName={id}))";
            search.SearchScope = SearchScope.Subtree;

            List<string> list = new List<string>();

            SearchResult result = search.FindOne();

            list.Add(result.Properties["samAccountName"][0].ToString());
            list.Add(result.Properties["givenName"][0].ToString());
            list.Add(result.Properties["sn"][0].ToString());
            list.Add(result.Properties["mail"][0].ToString());
            list.Add(result.Properties["distinguishedname"][0].ToString().Split(',')[1].Split('=').Last());

            return list;
        }
    }
}