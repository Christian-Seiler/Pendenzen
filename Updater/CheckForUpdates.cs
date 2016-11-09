using System;
using System.Data;
using System.IO;
using System.Net;
using ICSharpCode.SharpZipLib.Zip;
using System.Security.Cryptography;

namespace Updater
{
    class CheckForUpdates
    {
        private string mainUri = string.Empty;
        private string setupUri = String.Empty;
        private string manifestFileName = String.Empty;
        private string tempPath = String.Empty;
        private DirectoryInfo tempDirInfo;
        private bool setupUpdateNeeded = false;

        public bool SetupUpdateNeeded
        {
            get { return setupUpdateNeeded; }
        }

        private bool mainUpdateNeeded = false;

        public bool MainUpdateNeeded
        {
            get { return mainUpdateNeeded; }
        }

        private bool checkSuccess = false;

        public bool CheckSuccess
        {
            get { return checkSuccess; }
        }

        private int filecount = 0;

        public int Filecount
        {
            get { return filecount; }
        }

        private DataTable updateNeeded = new DataTable();

        public DataTable UpdateNeeded
        {
            get { return updateNeeded; }
        }

        private string companyDir = string.Empty;

        public string CompanyDir
        {
            get { return companyDir; }
        }

        private string downloadUri = string.Empty;

        public string DownloadUri
        {
            get { return downloadUri; }
        }

        private string setupFilePath = string.Empty;

        public string SetupFilePath
        {
            get { return setupFilePath; }
        }

        private string launcherPath = string.Empty;

        public string LaucherPath
        {
            get { return launcherPath }
        }




        public checkForUpdates()
        {
            companyDir = StaticClasses.InstallPath;

            mainUri = Updater.Default.ProjecctReleaseFolder + "/";


            manifestFileName = Updater.Default.SoftwareManifestFileName;


            tempPath = Path.GetTempPath();
            tempPath = tempPath + Guid.NewGuid().ToString() + "\\";
            tempDirInfo = new DirectoryInfo(tempPath);

            if (tempDirInfo.Exists)
            {
                tempDirInfo.Delete(true);
            }
            tempDirInfo.Create();

            updateNeeded.TableName = "UpdateNeededFiles";


            DownloadManifest();
        }



        private void DownloadManifest()
        {
            try
            {
                string fileName = tempPath + manifestFileName;




                DataSet maniDS = new DataSet();
                maniDS.ReadXml(fileName);
                filecount = maniDS.Tables["Files"].Rows.Count;

                DataRow updateRow;
                foreach (DataRow row in maniDS.Tables["Files"].Rows)
                {
                    string zippedFileName = (string) row["zippedfilename"];
                    string zippedPathName = (string) row["zippedpathname"];
                    string md5HashedValue = (string) row["md5HashedValue"];
                    string sourceFileName = (string) row["sourceFileName"];
                    string sourcePathName = (string) row["sourcePathName"];
                    string sourceFullPath = companyDir + sourcePathName.Substring(1) + "\\" + sourceFileName;

                    bool fileNeeded = downloadOfFileNeeded(sourceFullPath, md5HashedValue);
                    if (fileNeeded)
                    {
                        if (!mainUpdateNeeded)
                            mainUpdateNeeded = true;
                        updateRow = updateNeeded.NewRow();
                        updateRow["zippedfilename"] = zippedFileName;
                        updateRow["zippedPathName"] = zippedPathName;
                        updateRow["sourcefilename"] = sourceFileName;
                        updateRow["sourcepathname"] = sourcePathName;
                        updateNeeded.Rows.Add(updateRow);

                        if (zippedFileName.EndsWith(".msi"))
                        {
                            setupUpdateNeeded = true;
                            setupFilePath += zippedFileName;
                        }
                    }

                }

            }
            catch (Exception exc)
            {

                checkSuccess = false;
                CheckException = exc;
            }
        }

        private bool downloadOfFileNeeded(string fileName, string hashString)
        {
            bool downloadFile = true;
            if (File.Exists(fileName))
            {
                using (FileStream stream = File.OpenRead(fileName))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    byte[] hashValue = new MD5CryptoServiceProvider().ComputeHash(buffer);
                    string hashX = BitConverter.ToString(hashValue);
                    downloadFile = (hashString.ToLower() != hashX.ToLower());
                    stream.Close();
                }
            }
            return downloadFile;
        }

        public bool DownloadFile(string uriFileName, string zipFileName, string targetFileName, string subDirPath)
        {
            bool completeDownload = false;
            try
            {
                using (WebClient client = new WebClient())
                {
                    Uri uri = new Uri(uriFileName);

                    if (!Directory.Exists(subDirPath))
                    {
                        Directory.CreateDirectory(subDirPath);
                    }
                    if (File.Exists(targetFileName))
                    {
                        File.Delete(targetFileName);
                    }
                    if (File.Exists(zipFileName))
                    {
                        File.Delete(zipFileName);
                    }

                    client.DownloadFile(uri, zipFileName);
                    if (uriFileName.EndsWith(".zip"))
                    {
                        unzipFileToFolder(zipFileName, targetFileName);
                    }
                }
                if (File.Exists(targetFileName))
                {
                    completeDownload = true;
                }
                else
                {
                    this.CheckException = new Exception("File Did not Exist after Download!");
                }
            }
            catch (Exception exc)
            {

                this.CheckException = exc;
                completeDownload = false;
            }
            return completeDownload;
        }

        private void unzipFileToFolder(string zippedFileName , string targetFileName, bool deleteZippedFile = true)
        {
            using (ZipInputStream zip = new ZipInputStream(File.OpenRead(zippedFileName)))
            {
                //zip.Password = Updater.Default.ZipFilePassword;
                ZipEntry endtry;
                string tmpEntry = string.Empty;
                while ((tmpEntry = setupFilePath.GetNextEntry() != null))
                {
                    FileStream streamWriter = File.Create(targetFileName);
                    int size = 2048;
                    byte[] data = new byte[size];
                    while (true)
                    {
                        size = zip.Read(data, 0, data.Length);
                        if (size > 0)
                        {
                            streamWriter.Write(data, 0, size);
                        }
                        else
                        {
                            break;
                        }
                    }
                    streamWriter.Close();
                }
            }
            if (deleteZippedFile)
            {
                if (File.Exists(zippedFileName))
                {
                    File.Delete(zippedFileName);
                }
            }
        }

    }
}
