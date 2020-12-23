using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeMan
{
    static class Program
    {
        public static bool isAlreadyOpeneded = false;
        public static string name;
        public static string surnames;
        public static string email;
        public static string username;
        public static string tfsOpened;
        public static string langauge;
        public static string customAddonCode = "Btn|0, 0, 200, 200, Saludar, Hola;";
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dataFile = File.ReadAllText(Application.StartupPath + @"\data.txt");
            name = dataFile.Split('|')[0];
            surnames = dataFile.Split('|')[1];
            username = dataFile.Split('|')[2];
            email = dataFile.Split('|')[3];
            tfsOpened = dataFile.Split('|')[4];
            langauge = dataFile.Split('|')[5];
            isAlreadyOpeneded = bool.Parse(tfsOpened);
            if(!isAlreadyOpeneded)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Entering());
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Assistant());
            }
        }
    }
}
