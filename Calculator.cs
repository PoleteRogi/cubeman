using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeMan
{
    public partial class Calculator : Form
    {
        string calculationType;
        public Calculator()
        {
            InitializeComponent();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += 1;
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += 2;
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += 3;
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += 4;
        }

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += 5;
        }

        private void guna2GradientTileButton6_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += 6;
        }

        private void guna2GradientTileButton7_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += 7;
        }

        private void guna2GradientTileButton8_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += 8;
        }

        private void guna2GradientTileButton9_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += 9;
        }

        private void guna2GradientTileButton10_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += 0;
        }

        private void guna2GradientTileButton12_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "/";
            calculationType = "DIVIDE";
        }

        private void guna2GradientTileButton13_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "*";
            calculationType = "MULTIPLY";
        }

        private void guna2GradientTileButton14_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "+";
            calculationType += "ADD";
        }

        private void guna2GradientTileButton15_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "-";
            calculationType += "SUBSTRACT";
        }

        private void guna2GradientTileButton16_Click(object sender, EventArgs e)
        {
            switch(calculationType)
            {
                case "DIVIDE":
                    int firstNumberD = int.Parse(guna2TextBox1.Text.Split('/')[0]);
                    int secondNumberD = int.Parse(guna2TextBox1.Text.Split('/')[1]);
                    string resultD = (firstNumberD / secondNumberD).ToString();
                    guna2TextBox1.Text = resultD;
                    break;
                case "MULTIPLY":
                    int firstNumberM = int.Parse(guna2TextBox1.Text.Split('*')[0]);
                    int secondNumberM = int.Parse(guna2TextBox1.Text.Split('*')[1]);
                    string resultM = (firstNumberM * secondNumberM).ToString();
                    guna2TextBox1.Text = resultM;
                    break;
                case "ADD":
                    int firstNumberA = int.Parse(guna2TextBox1.Text.Split('+')[0]);
                    int secondNumberA = int.Parse(guna2TextBox1.Text.Split('+')[1]);
                    string resultA = (firstNumberA + secondNumberA).ToString();
                    guna2TextBox1.Text = resultA;
                    break;
                case "SUBSTRACT":
                    int firstNumberS = int.Parse(guna2TextBox1.Text.Split('-')[0]);
                    int secondNumberS = int.Parse(guna2TextBox1.Text.Split('-')[1]);
                    string resultS = (firstNumberS - secondNumberS).ToString();
                    guna2TextBox1.Text = resultS;
                    break;
            }
        }
    }
}
