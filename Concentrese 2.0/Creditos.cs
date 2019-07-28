using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concentrese_2._0
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void Creditos_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click_1(object sender, EventArgs e)
        {
           
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Concentrese concentrese = new Concentrese();
            concentrese.Show();
            this.Close();
        }
    }
}
