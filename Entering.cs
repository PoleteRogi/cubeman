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
    public partial class Entering : Form
    {
        public Entering()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = Properties.Resources.cubeman_idle;
            Dialog welcomeDialog;
            if(Program.langauge == "English")
            {
                welcomeDialog = new Dialog("I think we don't have properly introduced. I'm CubeMan :D! What's your name?");
                welcomeDialog.GoToAssistantPosition(this);
                welcomeDialog.Show();
            }
            else
            {
                welcomeDialog = new Dialog("No creo que nos hayamos presentado. Me llamo CubeMan :D! ¿Cual es tu nombre?");
                welcomeDialog.GoToAssistantPosition(this);
                welcomeDialog.Show();
            }
            timer1.Stop();
            new Registration().ShowDialog();
            Dialog wow;
            if(Program.langauge == "English")
            {
                wow = new Dialog("Wow, " + Program.name + " " + Program.surnames + "! Your name is very nice! Thanks for downloading CubeMan!");
                wow.GoToAssistantPosition(this);
                welcomeDialog.Hide();
                wow.Show();
            }
            else
            {
                wow = new Dialog("Wow, " + Program.name + " " + Program.surnames + "! Tu nombre es muy bonito! De todas formas, ¡Gracias por descargar CubeMan!");
                wow.GoToAssistantPosition(this);
                welcomeDialog.Hide();
                wow.Show();
            }
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            new Assistant().Show();
            this.Hide();
        }
    }
}
