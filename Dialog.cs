using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace CubeMan
{
    public partial class Dialog : Form
    {
        public char[] dialog;
        private int currentDialogChar = 0;
        Form assistantForMove;
        public char[] pauses = new char[3] { '.', ',', Environment.NewLine.ToCharArray()[0] };
        public Dialog(string englishmessage)
        {
            InitializeComponent();
            dialog = Actions.ToDialog(englishmessage);
        }

        private void Dialog_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(currentDialogChar != dialog.Length)
            {
                guna2HtmlLabel1.Text += dialog[currentDialogChar];
                currentDialogChar++;
            }
            GoToAssistantPosition(assistantForMove);
        }

        public void GoToAssistantPosition(Form assistant)
        {
            this.Location = new Point(assistant.Location.X + 100, assistant.Location.Y + 300);
            assistantForMove = assistant;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
