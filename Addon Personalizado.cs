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
    public partial class Addon_Personalizado : Form
    {
        List<string> events = new List<string>();
        public Addon_Personalizado()
        {
            InitializeComponent();
        }

        private void Addon_Personalizado_Load(object sender, EventArgs e)
        {
            string[] lines = Program.customAddonCode.Split(';');

            foreach(string line in lines)
            {
                string type = line.Split('|')[0];
                string properties;
                string coordX;
                string coordY;
                string sizeX;
                string sizeY;
                string text;
                string eventTrigger;
                if (type == "Btn")
                {
                    properties = line.Split('|')[1];
                    coordX = properties.Split(',')[0];
                    coordY = properties.Split(',')[1];
                    sizeX = properties.Split(',')[2];
                    sizeY = properties.Split(',')[3];
                    text = properties.Split(',')[5];
                    eventTrigger = properties.Split(',')[4];
                    Button button = new Button();
                    button.Location = new Point(int.Parse(coordX), int.Parse(coordY));
                    button.Size = new Size(int.Parse(sizeX), int.Parse(sizeY));
                    button.Text = text;
                    button.Click += Button_Click;
                    this.Controls.Add(button);
                }
                if (type == "Txt")
                {
                    properties = line.Split('|')[1];
                    coordX = properties.Split(',')[0];
                    coordY = properties.Split(',')[1];
                    sizeX = properties.Split(',')[2];
                    sizeY = properties.Split(',')[3];
                    text = properties.Split(',')[5];
                    eventTrigger = properties.Split(',')[4];
                    Label label = new Label();
                    label.Location = new Point(int.Parse(coordX), int.Parse(coordY));
                    //label.Size = new Size(int.Parse(sizeX), int.Parse(sizeY));
                    label.AutoSize = true;
                    label.Text = text;
                    this.Controls.Add(label);
                }
                if(type == "Evnt")
                {
                    string eventName = line.Split('|')[0];
                    string trigger = line.Split('|')[1];
                    string triggerArguments = line.Split('|')[2];
                    events.Add(eventName + "," + trigger + "," + triggerArguments);
                }
            } 
        }

        private void Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
