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
    public partial class Form1 : Form
    {
        public Form assistant;
        public Form1(Form form)
        {
            InitializeComponent();
            assistant = form;
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog(Actions.GetRandomJoke());
            dialog.Show();
            dialog.GoToAssistantPosition(assistant);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            Say say = new Say();
            say.Show();
            say.assistantToSay = assistant;
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            new Start().Show();
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            new Calculator().Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            new Developer().Show();
        }

        private void guna2TileButton6_Click(object sender, EventArgs e)
        {
            new Assistant2();
        }
    }
}
