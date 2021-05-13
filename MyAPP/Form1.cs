using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AIM.Modules.REG_db dbTool = new AIM.Modules.REG_db();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);

            key.CreateSubKey("AppName");
            key = key.OpenSubKey("AppName", true);


            key.CreateSubKey("AppVersion");
            key = key.OpenSubKey("AppVersion", true);

            key.SetValue("yourkey", "yourvalue");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Timestamp = DateTime.Now.ToString("dd-MM-yyyy");

            string key = "HKEY_CURRENT_USER\\SOFTWARE\\" + Application.ProductName + "\\" + Application.ProductVersion;
            string valueName = "Trial Period";

            Microsoft.Win32.Registry.SetValue(key, valueName, Timestamp, Microsoft.Win32.RegistryValueKind.String);
        }
    }
}
