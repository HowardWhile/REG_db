using Microsoft.Win32;
using System.Windows.Forms;

namespace AIM.Modules
{
    class REG_db
    {
        private const string k_root_path = @"HKEY_CURRENT_USER\"; // The path does not require administrator permissions

        public REG_db(string iAppName = "", string iCompanyName = "")
        {
            this.app_name = iAppName == "" ? Application.ProductName : iAppName;

            string company_name = iCompanyName == "" ? Application.CompanyName : iCompanyName;

            if (company_name == app_name || company_name == "")// company name is empty
            {
                this.current_path = $"SOFTWARE\\{app_name}\\";
                this.home_path = $"SOFTWARE\\";
            }
            else
            {
                this.current_path = $"SOFTWARE\\{company_name}\\{app_name}\\";
                this.home_path = $"SOFTWARE\\{company_name}\\";
            }

            this.full_path = k_root_path + this.current_path;
        }

        public void Save(string iName, object iValue)
        {
            System.Console.WriteLine($"[Save] {this.full_path}\\{iName}");
            Registry.SetValue(this.full_path, iName, iValue);
        }

        public object Load(string iName, object iDefault = null)
        {
            System.Console.WriteLine($"[Load] {this.full_path}\\{iName}");
            return Registry.GetValue(this.full_path, iName, iDefault);
        }

        public void Delete(string iName)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(this.current_path, true);
            System.Console.WriteLine(key);
            if (key != null)
            {
                try
                {
                    key.DeleteValue(iName);
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine(
                        $">>[{ex.Message}]\r\n" +
                        $">>{ex}");
                }
            }
        }

        public void DeleteAll()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(this.home_path, true);

            try
            {
                key.DeleteSubKeyTree(this.app_name);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(
                 $">>[{ex.Message}]\r\n" +
                 $">>{ex}");
            }
        }

        private string full_path = ""; // HKEY_CURRENT_USER\Software\CompanyName\AppName
        private string current_path = ""; // Software\CompanyName\AppName
        private string home_path = ""; // Software\CompanyName\
        private string app_name = "";
    }
}
