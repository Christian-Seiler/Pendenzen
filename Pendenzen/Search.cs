using System;
using System.Collections.Generic;
using System.Data;

namespace Pendenzen
{
    class Search
    {
        public static Dictionary<string, string> dictionaryForTab(int tab)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            if (tab == 0)            {
                dictionary.Add("ID", "idpendenz");
                dictionary.Add("Lieferant", "lieferant");
                dictionary.Add("Referenz-Nr.", "referenz");
                dictionary.Add("Dokument", "dokument");
                dictionary.Add("Erfasser", "erfasst_von");
                dictionary.Add("Sachbearbeiter", "sachbearbeiter");
                dictionary.Add("Status", "state");
                dictionary.Add("Abteilung", "department");            }            if (tab == 1)            {
                dictionary.Add("Kürzel", "company_id");
                dictionary.Add("Lieferant", "company_name");
                dictionary.Add("PLZ", "company_plz");
                dictionary.Add("City", "company_city");
                dictionary.Add("Land", "company_country");            }            if (tab == 2)            {
                dictionary.Add("ID", "id");
                dictionary.Add("Rechnung", "invoice");
                dictionary.Add("Gutschrift", "credit");
                dictionary.Add("Firma", "company");
                dictionary.Add("Betrag", "user");
                dictionary.Add("Datum", "date");
                dictionary.Add("Grund", "reason");
                dictionary.Add("Abteilung", "department");            }
            return dictionary;        }

        public static string[] getUsedCountry()
        {
            List<String> list = new List<string>();
            list.Add("");
            DBConnect db = new DBConnect();
            string query = "SELECT company_country FROM company group by company_country";
            foreach (DataRow row in db.Select(query).Rows)
            {
                list.Add(row[0].ToString());
            }
            return list.ToArray();
        }
    }
}
