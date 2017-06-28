using System;
using System.IO;
using System.Windows.Forms;
using System.Security;
using Pendenzen.Security;

namespace Pendenzen
{
    public class MakeConnection
    {
        public MakeConnection()
        {
            if (new DatabaseRegistry().valuesAreSet())
            {
                //if (validateLicenseFile()) {
                    DBConnect db = new DBConnect();
                    if (db.Open())
                    {
                        Application.Run(new mainForm());
                    }
                    else
                    {
                        MessageBox.Show("Cannot connect to server. Please contact administrator");
                    }
                //}
            }
            else
            {

            }
        }

        internal static bool validateLicenseFile()
        {
            try
            {
                // reserve a license object:
                License license = null;

                // get the public key from internal resource:
                String publicKey = Properties.Resources.publicKey;

                // work out the expected license file-name:
                String licenseFile = "\\\\srv01\\SYSVOL\\allpower.local\\license\\pendenzen.lic";
                //String licenseFile = Application.LocalUserAppDataPath + "\\" + Environment.UserName + "_user.lic";

                // does the license file exist?
                if (File.Exists(licenseFile))
                {
                    // load the license:
                    license = License.Load(licenseFile);
                }
                else
                {
                    // prompt the user for a license file:
                    OpenFileDialog dlg = new OpenFileDialog();

                    // setup a dialog;
                    dlg.Filter = "User License Files (*.lic)|*.lic";
                    dlg.Title = "Select License File";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // copy the license file into the sysvol license directory:
                            File.Copy(dlg.FileName, licenseFile);

                            // if it made it here, load it:
                            if (File.Exists(licenseFile))
                            {
                                license = License.Load(licenseFile);
                            }
                        }
                        catch
                        {
                            // can't copy the file?.. load the original:
                            license = License.Load(dlg.FileName);
                        }
                    }
                }
                if (license != null)
                {
                    // validate the signature on the license with the message contents, and the public key:
                    LicenseAuthorization.ValidateLicense(license, publicKey);

                    // if we get here, the license is valid;
                    return true;
                }
                else
                {
                    // no license file...
                    MessageBox.Show("License File Not Supplied!", "License Check");
                    return false;
                }
            }
            catch (SecurityException se)
            {
                // display the reason for the license check failure:
                MessageBox.Show(se.Message, "License Check");
            }

            // return false...invalid license.
            return false;
        }

    }
}