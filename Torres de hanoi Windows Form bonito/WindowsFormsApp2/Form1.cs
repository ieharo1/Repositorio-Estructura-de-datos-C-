using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Nombre de los integrantes: Alan Guijarro, Martin Guerra, Jack Narvaez, Isaac Haro
//6/11/2020
//Windows Form Torres de hanoi
namespace WindowsFormsApp2
{
    public partial class boton : Form
    {
        public boton()//Constructor
        {
            InitializeComponent();
            Visible2(false);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Aux(int cont1)//Mediante un auxiliar efectuamos los movimientos de la torre de hanoi
        {
                switch (cont1)
                {
                    case 1:
                    txt1.Visible = false;
                    txt10.Visible = true;
                    label4.Visible = true;
                    break;
                    case 2:
                        txt1.Visible = false;
                        txt10.Visible = true;
                        break;
                    case 3:
                        txt1.Visible = false;
                        txt20.Visible = true;
                        txt2.Visible = false;
                        break;
                    case 4:

                        txt10.Visible = false;
                        txt1000.Visible = true;
                        break;
                    case 5:
                        txt30.Visible = true;
                        txt3.Visible = false;
                        break;
                    case 6:
                        txt100.Visible = true;
                        txt1000.Visible = false;
                        break;
                    case 7:
                        txt20.Visible = false;
                        txt200.Visible = true;
                        break;
                    case 8:
                        txt100.Visible = false;
                        txt10000.Visible = true;
                        break;
                }
        }
        private void txt1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void Visible2(bool a)//Permite hacer visible al usuario los movimientos
        {
            txt1000.Visible = a;
            txt20.Visible = a;
            txt10.Visible = a;
            txt200.Visible = a;
            txt30.Visible = a;
            txt10.Visible = a;
            txt10000.Visible = a;
            txt100.Visible = a;
            label4.Visible = a;
        }
        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
        public int cont = 1;//Contador que ayuda cuando efectua la recursividad en las torres de hanoi
        private void button1_Click(object sender, EventArgs e)//Funcion para dar click en el boton
        {
            cont++;
            Aux(cont);
            label4.Text= tower(3, 'A', 'C', 'B');
        }
        private void paso_TextChanged(object sender, EventArgs e)
        {

        }
        static string tower(int n, char A, char C, char aux)//Funcion torre de hanoi
        {
            string res=" ";
            if (n == 1)
            {
                res= $" Mover el disco {n} de la torre {A} hacia la torre {C} "; 
                
            }
            else
            {
                tower(n - 1, A, aux, C); //RECURSIVIDAD
                res=$" Mover el disco {n} de la torre {A} hacia la torre {C} ";  
                tower(n - 1, aux, C, A); //RECURSIVIDAD
            }
            return res;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void boton_Load(object sender, EventArgs e)
        {

        }
    }
}
