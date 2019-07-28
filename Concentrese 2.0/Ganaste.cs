using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concentrese_2._0
{
    public partial class Ganaste : Form
    {
        public Ganaste()
        {
            InitializeComponent();
            string path = Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            path = Path.Combine(path, "Threnody.wav");
            SoundPlayer Player = new SoundPlayer(path);
            Player.Play();
        }

        private void Retry_Click(object sender, EventArgs e)
        {
            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
           
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RetryG_Click(object sender, EventArgs e)
        {
            Nivel1 nivel1 = new Nivel1();
            nivel1.Show();
            this.Close();
        }
    }
}
