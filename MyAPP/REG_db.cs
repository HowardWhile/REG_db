using Microsoft.Win32;
using System.Windows.Forms;

namespace AIM.Modules
{
    class REG_db
    {
        private const string k_root_path = @"HKEY_CURRENT_USER\";
        private string root_path = "";
        private string current_path = "";
        public REG_db(string iAppName = "", string iCompanyName = "")
        {
            string company_name = iCompanyName == "" ? Application.CompanyName : iCompanyName;
            string app_name = iAppName == "" ? Application.ProductName : iAppName;


            if (company_name == app_name || company_name == "")// company name is empty
            {
                this.current_path = $"SOFTWARE\\{app_name}\\";
            }
            else
            {
                this.current_path = $"SOFTWARE\\{company_name}\\{app_name}\\";
            }

            this.root_path = k_root_path + this.current_path;
        }

        public void Save(string iName, object iValue)
        {
            System.Console.WriteLine($"[Save] {this.root_path}\\{iName}");
            Registry.SetValue(this.root_path, iName, iValue);
        }

        public object Load(string iName, object iDefault = null)
        {
            System.Console.WriteLine($"[Load] {this.root_path}\\{iName}");
            return Registry.GetValue(this.root_path, iName, iDefault);
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
            //RegistryKey key = Registry.CurrentUser.OpenSubKey(this.current_path, true);


        }
    }
}
