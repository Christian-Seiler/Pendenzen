﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pendenzen.Properties {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Pendenzen.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die AutoUpdate ist aus! ähnelt.
        /// </summary>
        internal static string autoUpdateOff {
            get {
                return ResourceManager.GetString("autoUpdateOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Drawing.Icon ähnlich wie (Symbol).
        /// </summary>
        internal static System.Drawing.Icon favicon {
            get {
                object obj = ResourceManager.GetObject("favicon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Wähle die Firma, die diese Pendenz betrifft. Falls die Firma noch nicht vorhanden ist, kann diese über &quot;Neue Firma&quot; angelegt werden. ähnelt.
        /// </summary>
        internal static string helpCompany {
            get {
                return ResourceManager.GetString("helpCompany", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Jeder unternommene Schritt ist mit einem kurzen Satz zu dokumentieren. ähnelt.
        /// </summary>
        internal static string helpDetails {
            get {
                return ResourceManager.GetString("helpDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Die Belegnummer entspricht der Dokumentennummer der Lieferfirma. Auftragsbestätigung (AB), Lieferschein (LS), Gutschrift (GU) oder Rechnung (RG). ähnelt.
        /// </summary>
        internal static string helpDocument {
            get {
                return ResourceManager.GetString("helpDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Das Fälligkeitsdatum der Pendenz. Normalerweise innerhalb der kommenden 7 Tagen. ähnelt.
        /// </summary>
        internal static string helpDue {
            get {
                return ResourceManager.GetString("helpDue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Die Referenznummer entspricht unserer Bestellnummer im BusPro. ähnelt.
        /// </summary>
        internal static string helpReference {
            get {
                return ResourceManager.GetString("helpReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Derjenige Sachbearbeiter, der diese Pendenz bearbeitet. ähnelt.
        /// </summary>
        internal static string helpSB {
            get {
                return ResourceManager.GetString("helpSB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap logo {
            get {
                object obj = ResourceManager.GetObject("logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Die Suche hat keine Einträge gefunden, bitte suche mittels anderen Keywords oder setze die Suche zurück. ähnelt.
        /// </summary>
        internal static string restoreMessagge {
            get {
                return ResourceManager.GetString("restoreMessagge", resourceCulture);
            }
        }
    }
}
