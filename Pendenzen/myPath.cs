using System;

namespace Pendenzen
{
    public class MyPath
    {
        /// <summary>
        /// getPath creates the appropriate path for the given department and company
        /// </summary>
        /// <param name="isInland">bool describing whether the company is local or abroad</param>
        /// <param name="company">the name of the company</param>
        /// <param name="abteilung">the name of the department</param>
        /// <returns></returns>
        public static string getPath(bool isInland, string company, string abteilung)
        {
            string folder = "";
            switch (isInland)
            {
                case true:
                    folder = "Inland";
                    break;
                case false:
                    folder = "Ausland";
                    break;
            }


            switch (abteilung)
            {
                case "Einkauf":
                    // K:\Einkauf\Lieferanten\Inland\AAA\Korrespondenz
                    return $@"K:\Einkauf\Lieferanten\{folder}\{company}\Korrespondenz";
                case "Verkauf":
                    // K:\Verkauf\Kunden\Inland\AAA\Korrespondenz
                    return $@"K:\Verkauf\Kunden\{folder}\{company}\Korrespondenz";
                case "Buchhaltung":
                    // K:\Buchhaltung\Firmen\Inland\AAA
                    return $@"K:\Buchhaltung\Firmen\{folder}\{company}";
                default:
                return "-1";
            }
        }
    }
}
