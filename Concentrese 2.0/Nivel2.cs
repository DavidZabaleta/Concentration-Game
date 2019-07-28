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

namespace Concentrese_2._0
{
    public partial class Nivel2 : Form
    {
        public Nivel2()
        {
            InitializeComponent();
            RCarta1.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta2.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta3.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta4.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta5.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta6.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta7.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta8.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            Inicio();
            Inicio2();
            

        }

        //Variables
        int[,] vec = new int[2, 2];
        int[,] vec2 = new int[2, 2];
        string carta, cart, cart1, cart2;
        int giradas = 0, nivel = 1, pares = 0, cont1, cont2, x, y;
        Image img1 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl13.jpg");
        Image img2 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl14.jpg");
        Image img3 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl15.jpg");
        Image img4 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl16.jpg");     
        Image img9 = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");

        void Inicio()
        {
            Random y = new Random();
            x = y.Next(1, 5);
            if (x == 1)
            {
                int[,] vecaux = { { 1, 2 }, { 2, 1 } };
                vec = vecaux;
            }
            if (x == 2)
            {
                int[,] vecaux = { { 2, 1 }, { 1, 2 } };
                vec = vecaux;
            }
            if (x == 3)
            {
                int[,] vecaux = { { 1, 1 }, { 2, 2 } };
                vec = vecaux;
            }
            if (x == 4)
            {
                int[,] vecaux = { { 2, 2 }, { 1, 1 } };
                vec = vecaux;
            }

        }

        void Inicio2()
        {
            Random y = new Random();
            x = y.Next(1, 5);
            if (x == 1)
            {
                int[,] vecaux = { { 4, 3 }, { 3, 4 } };
                vec2 = vecaux;
            }
            if (x == 2)
            {
                int[,] vecaux = { { 3, 4 }, { 4, 3 } };
                vec2 = vecaux;
            }
            if (x == 3)
            {
                int[,] vecaux = { { 3, 3 }, { 4, 4 } };
                vec2 = vecaux;
            }
            if (x == 4)
            {
                int[,] vecaux = { { 4, 4 }, { 3, 3 } };
                vec2 = vecaux;
            }
        }

        void Voltear()
        {
            if (carta == "1")
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
                    RCarta5.Image = img1;
                }
                else
                {
                    RCarta5.Image = img2;
                }
            }
            if (carta == "4")
            {
                if (vec[1, 1] == 1)
                {
                    RCarta6.Image = img1;
                }
                else
                {
                    RCarta6.Image = img2;
                }
            }
        }
        void Voltear1()
        {
            if (carta == "5")
            {
                if (vec2[0, 0] == 3)
                {
                    RCarta3.Image = img3;
                }
                else
                {
                    RCarta3.Image = img4;
                }
            }
            if (carta == "6")
            {
                if (vec2[0, 1] == 3)
                {
                    RCarta4.Image = img3;
                }
                else
                {
                    RCarta4.Image = img4;
                }
            }
            if (carta == "7")
            {
                if (vec2[1, 0] == 3)
                {
                    RCarta7.Image = img3;
                }
                else
                {
                    RCarta7.Image = img4;
                }
            }
            if (carta == "8")
            {
                if (vec2[1, 1] == 3)
                {
                    RCarta8.Image = img3;
                }
                else
                {
                    RCarta8.Image = img4;
                }
            }
        }

        void Comparar()
        {
            if (cont1 != cont2)
            {
                if (cart1 == "1")
                {
                    RCarta1.Image = img9;
                }
                if (cart2 == "1")
                {
                    RCarta1.Image = img9;
                }
                if (cart1 == "2")
                {
                    RCarta2.Image = img9;
                }
                if (cart2 == "2")
                {
                    RCarta2.Image = img9;
                }
                if (cart1 == "3")
                {
                    RCarta3.Image = img9;
                }
                if (cart2 == "3")
                {
                    RCarta3.Image = img9;
                }
                if (cart1 == "4")
                {
                    RCarta4.Image = img9;
                }
                if (cart2 == "4")
                {
                    RCarta4.Image = img9;
                }
                if (cart1 == "5")
                {
                    RCarta5.Image = img9;
                }
                if (cart2 == "5")
                {
                    RCarta5.Image = img9;
                }
                if (cart1 == "6")
                {
                    RCarta6.Image = img9;
                }
                if (cart2 == "6")
                {
                    RCarta6.Image = img9;
                }
                if (cart1 == "7")
                {
                    RCarta7.Image = img9;
                }
                if (cart2 == "7")
                {
                    RCarta7.Image = img9;
                }
                if (cart1 == "8")
                {
                    RCarta8.Image = img9;
                }
                if (cart2 == "8")
                {
                    RCarta8.Image = img9;
                }                
            }
            else
            {
                giradas = 0;
                pares += 1;
            }
        }
        private void Nivel3_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Concentrese Menu_ = new Concentrese();
            Menu_.Show();
            this.Close();
        }

        private void RCarta8_Click(object sender, EventArgs e)
        {
            carta = "8";
            Voltear1();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[1, 1];
                cart1 = "8";
            }
            if (giradas == 2)
            {
                cont2 = vec[1, 1];
                cart2 = "8";
                Comparar();
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            Nivel3 win = new Nivel3 ();
            win.Show();
            this.Close();
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

        private void RCarta6_Click(object sender, EventArgs e)
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

        private void RCarta5_Click(object sender, EventArgs e)
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
            carta = "6";
            Voltear1();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[0, 1];
                cart1 = "6";
            }
            if (giradas == 2)
            {
                cont2 = vec[0, 1];
                cart2 = "6";
                Comparar();
            }
        }

        private void RCarta3_Click(object sender, EventArgs e)
        {
            carta = "5";
            Voltear1();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[0, 0];
                cart1 = "5";
            }
            if (giradas == 2)
            {
                cont2 = vec[0, 0];
                cart2 = "5";
                Comparar();
            }
        }

        private void RCarta7_Click(object sender, EventArgs e)
        {
            carta = "7";
            Voltear1();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[1, 0];
                cart1 = "7";
            }
            if (giradas == 2)
            {
                cont2 = vec[1, 0];
                cart2 = "7";
                Comparar();
            }
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
    }
}
