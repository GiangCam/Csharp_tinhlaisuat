using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_tinhlaisuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double tienlai;
            double laisuat = double.Parse(txtlai.Text.Replace("%",""))/100;
            double sotien, nam, ketqua;
            sotien = double.Parse(txtsotien.Text);
            nam = double.Parse(txtnam.Text);
           for (int i = 1; i < nam; i++) 

            {
                tienlai = sotien * laisuat;
                lbxKQ.Items.Add($"{1}\t {sotien:F2}\t\t\t {tienlai:F2}");
            }
        }
    }
}
