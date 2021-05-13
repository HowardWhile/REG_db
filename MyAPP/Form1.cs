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
        }

        AIM.Modules.REG_db dbTool = new AIM.Modules.REG_db();


        string name_para1 = "random_value";
        string name_para2 = "timestamp";

        private void btn_save1_Click(object sender, EventArgs e)
        {
            System.Random rand = new Random();

            int value = rand.Next();

            this.dbTool.Save(this.name_para1, value);

        }

        private void btn_save2_Click(object sender, EventArgs e)
        {
            string value = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff");

            this.dbTool.Save(this.name_para2, value);

        }

        private void btn_remove1_Click(object sender, EventArgs e)
        {
            this.dbTool.Delete(this.name_para1);
        }

        private void btn_remove2_Click(object sender, EventArgs e)
        {
            this.dbTool.Delete(this.name_para2);
        }

        private void btn_load1_Click(object sender, EventArgs e)
        {
            var oValue = this.dbTool.Load(this.name_para1);
            System.Console.WriteLine(oValue);
        }

        private void btn_load2_Click(object sender, EventArgs e)
        {
            var oValue = this.dbTool.Load(this.name_para2);
            System.Console.WriteLine(oValue);
        }
    }
}
