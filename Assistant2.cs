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
    public partial class Assistant2 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Assistant2()
        {
            InitializeComponent();
        }

        private void Assistant2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.kid_entering;
            timer1.Interval = new Random().Next(10, 30) * 1000;
            timer3.Interval = new Random().Next(30, 60) * 1000;
        }

        private void Assistant2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Assistant2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Assistant2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            if (e.Button == MouseButtons.Left)
            {
                int isDialogShowed = new Random().Next(0, 2);
                if (isDialogShowed == 1)
                {
                    Dialog dialog;
                    if (Program.langauge == "English")
                    {
                        dialog = new Dialog("Oh! Is here where you want me?");
                        dialog.Show();
                        dialog.GoToAssistantPosition(this);
                    }
                    else
                    {
                        dialog = new Dialog("Oh! ¿Es aquí donde me quieres?");
                        dialog.Show();
                        dialog.GoToAssistantPosition(this);
                    }
                    //pictureBox1.Image = Properties.Resources.cubeman_jump;
                    //timer2.Start();
                    timer1.Stop();
                }
            }
        }

        private void showCubeMansWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1(this).Show();
        }

        private void tellAJokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog(Actions.GetRandomJoke());
            dialog.Show();
            dialog.GoToAssistantPosition(this);
        }

        private void saySomethingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Say say = new Say();
            say.Show();
            say.assistantToSay = this;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Start().Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Calculator().Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Dialog randomDialog = new Dialog(Actions.GetRandomPhrase());
            randomDialog.GoToAssistantPosition(this);
            randomDialog.Show();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.kid_idle;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.kid_idle;
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int locationX;
            int locationY;
            locationX = new Random().Next(this.Location.X + 10, this.Location.X + 500);
            locationY = new Random().Next(this.Location.Y + 100, this.Location.Y + 500);
            this.Location = new Point(locationX, locationY);
            pictureBox1.Image = Properties.Resources.kid_jumping;
            timer2.Start();
        }
    }
}
