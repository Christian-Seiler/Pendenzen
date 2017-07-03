﻿using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Security.Principal;

namespace Pendenzen
{
    public class Person
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