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
    public partial class Nivel3 : Form
    {
        public Nivel3()
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
            RCarta9.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta10.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta11.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta12.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta13.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta14.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta15.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            RCarta16.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");
            Inicio();
            Inicio2();
            Inicio3();
            Inicio4();
        }

        //Variables
        int[,] vec = new int[2, 2];
        int[,] vec2 = new int[2, 2];
        int[,] vec3 = new int[2, 2];
        int[,] vec4 = new int[2, 2];
        string carta, cart, cart1, cart2;
        int giradas = 0, nivel = 1, pares = 0, cont1, cont2, x, y;
        Image img1 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl1.jpg");
        Image img2 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl2.jpg");
        Image img3 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl3.jpg");
        Image img4 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl4.jpg");
        Image img5 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl5.jpg");
        Image img6 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl6.jpg");
        Image img7 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl7.jpg");
        Image img8 = Image.FromFile(Application.StartupPath + @"\Imagenes\Niveles\lvl8.jpg");
        Image img9 = Image.FromFile(Application.StartupPath + @"\Imagenes\BackCarta.png");

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
                int[,] vecaux = { { 5, 6 }, { 6, 5 } };
                vec2 = vecaux;
                
            }
            if (x == 2)
            {
                int[,] vecaux = { { 6, 5 }, { 5, 6 } };
                vec2 = vecaux;
            }
            if (x == 3)
            {
                int[,] vecaux = { { 5, 5 }, { 6, 6 } };
                vec2 = vecaux;
            }
            if (x == 4)
            {
                int[,] vecaux = { { 6, 6 }, { 5, 5 } };
                vec2 = vecaux;
                
            }
        }
        void Inicio3()
        {
            Random y = new Random();
            x = y.Next(1, 5);
            if (x == 1)
            {
                int[,] vecaux = { { 4, 3 }, { 3, 4 } };
                vec3 = vecaux;
            }
            if (x == 2)
            {
                int[,] vecaux = { { 3,4 }, { 4, 3 } };
                vec3 = vecaux;
            }
            if (x == 3)
            {
                int[,] vecaux = { { 3, 3 }, { 4, 4 } };
                vec3 = vecaux;
            }
            if (x == 4)
            {
                int[,] vecaux = { { 4, 4 }, { 3, 3 } };
                vec3 = vecaux;
            }
        }
        void Inicio4()
        {
            Random y = new Random();
            x = y.Next(1, 5);
            if (x == 1)
            {
                int[,] vecaux = { { 7, 8 }, { 8, 7 } };
                vec4 = vecaux;
            }
            if (x == 2)
            {
                int[,] vecaux = { { 8, 7 }, { 7, 8 } };
                vec4 = vecaux;
            }
            if (x == 3)
            {
                int[,] vecaux = { { 7, 7 }, { 8, 8 } };
                vec4 = vecaux;
            }
            if (x == 4)
            {
                int[,] vecaux = { { 8, 8 }, { 7, 7 } };
                vec4 = vecaux;
            }
        }

        //Metodo para que las cartas cambien de imagen...Cmabiar por un Switch(?)
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

        //Metodo para que las cartas cambien de imagen...Cmabiar por un Switch(?)
        void Voltear1()
        {
            if (carta == "5")
            {
                if (vec2[0, 0] == 5)
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
                if (vec2[0, 1] == 5)
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
                if (vec2[1, 0] == 5)
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
                if (vec2[1, 1] == 5)
                {
                    RCarta8.Image = img3;
                }
                else
                {
                    RCarta8.Image = img4;
                }
            }
        }

        //Metodo para que las cartas cambien de imagen...Cmabiar por un Switch(?)
        void Voltear2()
        {
            if (carta == "9")
            {
                if (vec3[0, 0] == 3)
                {
                    RCarta9.Image = img5;
                }
                else
                {
                    RCarta9.Image = img6;
                }
            }
            if (carta == "10")
            {
                if (vec3[0, 1] == 3)
                {
                    RCarta10.Image = img5;
                }
                else
                {
                    RCarta10.Image = img6;
                }
            }
            if (carta == "11")
            {
                if (vec3[1, 0] == 3)
                {
                    RCarta13.Image = img5;
                }
                else
                {
                    RCarta13.Image = img6;
                }
            }
            if (carta == "12")
            {
                if (vec3[1, 1] == 3)
                {
                    RCarta14.Image = img5;
                }
                else
                {
                    RCarta14.Image = img6;
                }
            }
        }
        void Voltear3()
        {
            if (carta == "13")
            {
                if (vec4[0, 0] == 7)
                {
                    RCarta11.Image = img7;
                }
                else
                {
                    RCarta11.Image = img8;
                }
            }
            if (carta == "14")
            {
                if (vec4[0, 1] == 7)
                {
                    RCarta12.Image = img7;
                }
                else
                {
                    RCarta12.Image = img8;
                }
            }
            if (carta == "15")
            {
                if (vec4[1, 0] == 7)
                {
                    RCarta15.Image = img7;
                }
                else
                {
                    RCarta15.Image = img8;
                }
            }
            if (carta == "16")
            {
                if (vec4[1, 1] == 7)
                {
                    RCarta16.Image = img7;
                }
                else
                {
                    RCarta16.Image = img8;
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
                if (cart1 == "9")
                {
                    RCarta9.Image = img9;
                }
                if (cart2 == "9")
                {
                    RCarta9.Image = img9;
                }
                if (cart1 == "10")
                {
                    RCarta10.Image = img9;
                }
                if (cart2 == "10")
                {
                    RCarta10.Image = img9;
                }
                if (cart1 == "11")
                {
                    RCarta11.Image = img9;
                }
                if (cart2 == "11")
                {
                    RCarta11.Image = img9;
                }
                if (cart1 == "12")
                {
                    RCarta12.Image = img9;
                }
                if (cart2 == "12")
                {
                    RCarta12.Image = img9;
                }
                if (cart1 == "13")
                {
                    RCarta13.Image = img9;
                }
                if (cart2 == "13")
                {
                    RCarta13.Image = img9;
                }
                if (cart1 == "14")
                {
                    RCarta14.Image = img9;
                }
                if (cart2 == "14")
                {
                    RCarta14.Image = img9;
                }
                if (cart1 == "15")
                {
                    RCarta15.Image = img9;
                }
                if (cart2 == "15")
                {
                    RCarta15.Image = img9;
                }
                if (cart1 == "16")
                {
                    RCarta16.Image = img9;
                }
                if (cart2 == "16")
                {
                    RCarta16.Image = img9;
                }
            }
            else
            {
                giradas = 0;
                pares += 1;                
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

        private void RCarta9_Click(object sender, EventArgs e)
        {
            carta = "9";
            Voltear2();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[0, 0];
                cart1 = "9";
            }
            if (giradas == 2)
            {
                cont2 = vec[0, 0];
                cart2 = "9";
                Comparar();
            }
        }

        private void RCarta10_Click(object sender, EventArgs e)
        {
            carta = "10";
            Voltear2();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[0, 1];
                cart1 = "10";
            }
            if (giradas == 2)
            {
                cont2 = vec[0, 1];
                cart2 = "10";
                Comparar();
            }
        }

        private void RCarta11_Click(object sender, EventArgs e)
        {
            carta = "13";
            Voltear3();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[0, 0];
                cart1 = "13";
            }
            if (giradas == 2)
            {
                cont2 = vec[0, 0];
                cart2 = "13";
                Comparar();
            }
        }

        private void RCarta12_Click(object sender, EventArgs e)
        {
            carta = "14";
            Voltear3();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[0, 1];
                cart1 = "14";
            }
            if (giradas == 2)
            {
                cont2 = vec[0, 1];
                cart2 = "14";
                Comparar();
            }
        }

        private void RCarta13_Click(object sender, EventArgs e)
        {
            carta = "11";
            Voltear2();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[1, 0];
                cart1 = "11";
            }
            if (giradas == 2)
            {
                cont2 = vec[1, 0];
                cart2 = "11";
                Comparar();
            }
        }

        private void RCarta14_Click(object sender, EventArgs e)
        {
            carta = "12";
            Voltear2();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[1, 1];
                cart1 = "12";
            }
            if (giradas == 2)
            {
                cont2 = vec[1, 1];
                cart2 = "12";
                Comparar();
            }
        }

        private void RCarta15_Click(object sender, EventArgs e)
        {
            carta = "15";
            Voltear3();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[1, 0];
                cart1 = "15";
            }
            if (giradas == 2)
            {
                cont2 = vec[1, 0];
                cart2 = "15";
                Comparar();
            }
        }

        private void RCarta16_Click(object sender, EventArgs e)
        {
            carta = "16";
            Voltear3();
            giradas += 1;
            if (giradas == 1)
            {
                cont1 = vec[1, 1];
                cart1 = "16";
            }
            if (giradas == 2)
            {
                cont2 = vec[1, 1];
                cart2 = "16";
                Comparar();
            }
        }       

        private void Nivel2_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Concentrese Menu_ = new Concentrese();
            Menu_.Show();
            this.Close();
        }

        private void Flecha_Click(object sender, EventArgs e)
        {
            Nivel2 lvl3_ = new Nivel2();
            lvl3_.Show();
            this.Close();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            Ganaste lvl3_ = new Ganaste();
            lvl3_.Show();
            this.Close();
        }
    }
}
