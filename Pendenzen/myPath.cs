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

            var path = "";

            switch (abteilung)
            {
                case "Einkauf":
                    // K:\Einkauf\Lieferanten\Inland\AAA\Korrespondenz
                    path = $@"K:\Einkauf\Lieferanten\{folder}\{company}\Korrespondenz";
                    break;
                case "Verkauf":
                    // K:\Verkauf\Kunden\Inland\AAA\Korrespondenz
                    path = $@"K:\Verkauf\Kunden\{folder}\{company}\Korrespondenz";
                    break;
                case "Buchhaltung":
                    // K:\Buchhaltung\Firmen\Inland\AAA
                    path = $@"K:\Buchhaltung\Firmen\{folder}\{company}";
                    break;
                default:
                    path = "-1";
                    break;
            }
            Console.WriteLine(path);
            return path;
        }
    }
}
