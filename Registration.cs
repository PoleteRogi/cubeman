using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeMan
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PrivacyPolicy().Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Program.name = guna2TextBox1.Text;
            Program.surnames = guna2TextBox2.Text;
            Program.username = guna2TextBox3.Text;
            Program.email = guna2TextBox4.Text;
            Program.langauge = guna2ComboBox1.Text;
            File.WriteAllText(Application.StartupPath + @"\data.txt", Program.name + "|" +  Program.surnames + "|" + Program.username + "|" + Program.email + "|true|" + Program.langauge);
        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2ImageCheckBox1.Checked)
            {
                guna2Button1.Enabled = true;
            }
            else
            {
                guna2Button1.Enabled = false;
            }
        }
    }
}
