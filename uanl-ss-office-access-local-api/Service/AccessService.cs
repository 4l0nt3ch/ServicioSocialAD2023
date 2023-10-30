using Microsoft.Office.Interop.Access;
using System.Data.OleDb;
using System.Runtime.InteropServices;


namespace uanl_ss_lib_office_access_local_api.Service
{
    public class AccessService
    {
        private string ACFile { get; set; }
        private Application ACApplication { get; set; }

        public AccessService(string aCFile)
        {
            ACFile = aCFile;
            ACApplication = ACOpenApplication();
            ACOpenDB();
        }

        private Application ACOpenApplication()
        {
            if (ACApplication == null)
            {
                return new Application();
            }
            else
            {
                return ACOpenApplication();
            }
        }

        private void ACOpenDB()
        {
            if (File.Exists(ACFile))
            {
                ACApplication.OpenCurrentDatabase(ACFile);
            }
            else
            {
                ACApplication.CreateAccessProject(ACFile);
            }

        }

        public void ACShutdown()
        {
            if (ACApplication != null)
            {
                ACApplication.CloseCurrentDatabase();
                Marshal.ReleaseComObject(ACApplication);
                ACApplication = null;
            }
        }

    }
}
