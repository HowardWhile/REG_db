using System.Windows.Forms;

namespace AIM.Modules
{
    class REG_db
    {
        private const string k_root_path = @"HKEY_CURRENT_USER\SOFTWARE\";
        private string db_path = "";
        public REG_db(string iAppName = "", string iCompanyName = "")
        {
            string company_name = iCompanyName == "" ? Application.CompanyName : iCompanyName;
            string app_name = iAppName == "" ? Application.ProductName : iAppName;


           // this.db_path = iPath;
        }

    }
}
