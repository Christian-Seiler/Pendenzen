using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendenzen
{
    class Path
    {

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
                    // K:\Buchhaltung\Firmen\AAA
                    path = $@"K:\Buchhaltung\Firmen\{company}";
                    break;
                default:
                    path = "-1";
                    break;
            }
            
            return path;
        }
    }
}
