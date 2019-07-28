using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;

namespace Concentrese_2._0
{
    public partial class Concentrese : Form
    {
        public Concentrese()
        {
            InitializeComponent();
            
            string path = Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            path = Path.Combine(path, "Threnody.wav");
            SoundPlayer Player = new SoundPlayer(path);
            Player.Play();
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            Nivel1 nivel1 = new Nivel1();
            nivel1.Show();
            this.Hide();            
            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Concentrese_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Creditos_Click(object sender, EventArgs e)
        {
            Creditos credit = new Creditos();
            credit.Show();
            this.Hide();
        }
    }
}
