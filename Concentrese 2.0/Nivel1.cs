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
using System.Reflection;
using System.IO;

namespace Concentrese_2._0
{
    public partial class Nivel1 : Form
    {
        public Nivel1()
        {
            InitializeComponent();
            Inicio();

            //Musica
            string path = Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            path = Path.Combine(path, "Smile.wav");
            SoundPlayer Player = new SoundPlayer(path);
            Player.Play();

            //Imagenes
            RCarta1.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta2.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta3.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta4.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
        }

        //Variables
        int[,] vec = new int[2, 2];
        string carta, cart, cart1, cart2;
        int giradas = 0, nivel = 1, pares = 0, cont1, cont2, x, y;
        Image img1 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl3.jpg");
        Image img2 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl9.jpg");
        Image img3 = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");

        //Se define el vector para las ubicaciones de las imagenes con un random
        void Inicio()
        {
            Random y = new Random();
            x = y.Next(1, 5);
            if (x == 1)
            {
                int[,] vecaux = { { 1, 2 }, { 2, 1 } };
                vec = vecaux;
            }
            if(x == 2)
            {
                int[,] vecaux2 = { { 2, 1 }, { 1, 2 } };
                vec = vecaux2;
            }
            if (x == 3)
            {
                int[,] vecaux3 = { { 1, 1 }, { 2, 2 } };
                vec = vecaux3;
            }
            if (x == 4)
            {
                int[,] vecaux4 = { { 2, 2 }, { 1, 1 } };
                vec = vecaux4;
            }
        }

        //Metodo para que las cartas cambien de imagen...Cmabiar por un Switch(?)
        void Voltear()
        {
            if(carta == "1")
            {
                if (vec[0, 0] == 1)
                {
                    RCarta1.Image = img1;
                }
                else
                {
                    RCarta1.Image = img2;
                }
            }
            if (carta == "2")
            {
                if (vec[0, 1] == 1)
                {
                    RCarta2.Image = img1;
                }
                else
                {
                    RCarta2.Image = img2;
                }
            }
            if (carta == "3")
            {
                if (vec[1, 0] == 1)
                {
                    RCarta3.Image = img1;
                }
                else
                {
                    RCarta3.Image = img2;
                }
            }
            if (carta == "4")
            {
                if (vec[1, 1] == 1)
                {
                    RCarta4.Image = img1;
                }
                else
                {
                    RCarta4.Image = img2;
                }
            }

        }

        void Comparar()
        {
            if (cont1 != cont2)
            {
                if (cart1 == "1")
                {
                    RCarta1.Image = img3;
                }
                if (cart2 == "1")
                {
                    RCarta1.Image = img3;
                }
                if (cart1 == "2")
                {
                    RCarta2.Image = img3;
                }
                if (cart2 == "2")
                {
                    RCarta2.Image = img3;
                }
                if (cart1 == "3")
                {
                    RCarta3.Image = img3;
                }
                if (cart2 == "3")
                {
                    RCarta3.Image = img3;
                }
                if (cart1 == "4")
                {
                    RCarta4.Image = img3;
                }
                if (cart2 == "4")
                {
                    RCarta4.Image = img3;
                }
            }
            
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Concentrese Menu_ = new Concentrese();
            Menu_.Show();
            this.Close();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RCarta1_Click(object sender, EventArgs e)
        {
            carta = "1";
            Voltear();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[0, 0];
                cart1 = "1";
            }
            if (giradas == 2)
            {
                cont2 = vec[0, 0];
                cart2 = "1";
                Comparar();
            }

        }

        private void RCarta2_Click(object sender, EventArgs e)
        {
            carta = "2";
            Voltear();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[0, 1];
                cart1 = "2";
            }
            if (giradas == 2)
            {
                cont2 = vec[0, 1];
                cart2 = "2";
                Comparar();
            }
        }

        private void RCarta3_Click(object sender, EventArgs e)
        {
            carta = "3";
            Voltear();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[1, 0];
                cart1 = "3";
            }
            if (giradas == 2)
            {
                cont2 = vec[1, 0];
                cart2 = "3";
                Comparar();
            }
        }

        private void RCarta4_Click(object sender, EventArgs e)
        {
            carta = "4";
            Voltear();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[1, 1];
                cart1 = "4";
            }
            if (giradas == 2)
            {
                cont2 = vec[1, 1];
                cart2 = "4";
                Comparar();
            }
        }

        private void Flecha_Click(object sender, EventArgs e)
        {
            Nivel3 lvl2_ = new Nivel3();
            lvl2_.Show();
            this.Close();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            Nivel2 lvl2_ = new Nivel2();
            lvl2_.Show();
            this.Close();
        }

        private void Nivel1_Load(object sender, EventArgs e)
        {

        }
    }
}
