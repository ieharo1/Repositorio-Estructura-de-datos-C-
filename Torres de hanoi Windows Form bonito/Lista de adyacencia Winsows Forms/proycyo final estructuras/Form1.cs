using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Isaac Haro, Alan Guijarro, Jack Narvaez, Martin Guerra
namespace proycyo_final_estructuras
{
    public partial class Form1 : Form
    {
        public Form1()//form
        {
            InitializeComponent();
            Visible(false);
        }
        public void Visible(bool a)
        {
            lista.Visible = a;
            listBox1.Visible = a;
            //listBox2.Visible = a;
            //label4.Visible = a;
            //label5.Visible = a;
        }
        private void preguntanodo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void INICIALIZAR(List<Nodo> p1)//inicializar
        {
            List<Nodo> aux = p1;
            string[] n2;
            char r;
            for (int i = 0; i < p1.Count; i++)
            {
                Nodo comienzo = p1[i];
                if (MessageBox.Show($"¿Su nodo {p1[i].dato} tiene alguna conexión?", "SI O NO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int j = 0; j < aux.Count; j++)
                    {
                        if (MessageBox.Show($"Su nodo {p1[i].dato} se conecta {aux[j].dato}","SI O NO",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            comienzo.Siguiente = new Nodo(aux[j].dato);
                            comienzo = comienzo.Siguiente;
                        }
                    }
                }
            }
            lista.Visible = true;
        }
        private void PrintList(List<Nodo> p1)//imprimir la lista
        {
            for (int i = 0; i < p1.Count; i++)
            {
                Nodo aux = p1[i];
                while (aux != null)
                {
                    listBox1.Visible = true;
                    listBox1.Items.Insert(i, aux.dato);
                    aux = aux.Siguiente;
                }
                listBox1.Items.Insert(i, "");
            }
        }
        private void PrintStack(Stack<string> s1)
        {
            string[] aux = s1.ToArray();
            for (int i = 0; i < aux.Length; i++)
            {
                //listBox2.Visible = true;
                //listBox2.Items.Insert(i, aux[i]);
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] n;
            Nodo aux;
            List<Nodo> p1 = new List<Nodo>();
            Stack<string> s1 = new Stack<string>();
            n = (textBox1.Text).Split(',');
            for (int i = 0; i < n.Length; i++)
            {
                aux = new Nodo(n[i]);
                p1.Add(aux);
            }
            INICIALIZAR(p1);
            PrintList(p1);
            //Pila(p1, s1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void Pila(List<Nodo> p1, Stack<string> s1) 
        {
            string op;
            Stack<string> s2 = new Stack<string>();
            int k = 0, j = 0;
            for (int i = 0; i < p1.Count; i++)
            {
                if(MessageBox.Show($"Desea que su nodo empiece su busqueda en profundidad desde {p1[i].dato}","SI O NO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    op = p1[i].dato;
                    while (p1[k].dato != op)
                    {
                        k++;
                    }
                    s2.Push(p1[k].dato);
                    Nodo aux2 = p1[k];
                    for (int jq = 0; jq < p1.Count; jq++)
                    {
                        while (aux2.Siguiente!=null)
                        {
                            aux2 = aux2.Siguiente;
                            s1.Push(aux2.dato);
                        }
                        string[] aux = s1.ToArray();
                        s1.Clear();
                        s1 = Eliminar(aux, s1);
                        string[] aux3 = s1.ToArray();
                        s1 = Eliminar2(aux3, s2);
                        string[] aux5 = s1.ToArray();
                        if (aux5.Length!=0)
                        {
                            s2.Push(s1.Pop());
                            string[] aux4 = s2.ToArray();
                            jq = 0;
                            do
                            {
                                if (p1[jq].dato!=aux4[0])
                                {
                                    j++;
                                }
                            } while (p1[jq].dato!=aux4[0]);
                            aux2 = p1[jq];
                        }
                        else
                        {
                            break;
                        }
                    }
                    //label4.Visible = true;
                    PrintStack(s2);
                    break;
                }
            }
         
        }
        public static Stack<string> Eliminar2(string[] aux, Stack<string> s2)
        {
            Stack<string> saux = new Stack<string>();
            string[] principal = s2.ToArray();
            for (int k = 0; k < aux.Length; k++)
            {
                for (int i = 0; i < principal.Length; i++)
                {
                    if (aux[k] == principal[i])
                    {
                        aux[k] = null;
                    }
                }
            }

            for (int j = aux.Length - 1; j >= 0; j--)
            {
                if (aux[j] != null)
                {
                    saux.Push(aux[j]);
                    Console.WriteLine(aux[j]);
                }

            }
            return saux;
        }
        public static Stack<string> Eliminar(string[] aux, Stack<string> s1)
        {
            for (int j = 0; j < aux.Length; j++)
            {
                for (int k = 0; k < aux.Length; k++)
                {
                    if (k == j && j != aux.Length - 1)
                    {
                        k++;
                    }
                    if (aux[j] == aux[k] && j != aux.Length - 1 && k != aux.Length - 1)
                    {
                        aux[j] = null;
                    }
                    if (j == aux.Length - 1 && aux[k] == aux[j] && k != aux.Length - 1)
                    {
                        aux[j] = null;
                    }
                }
            }
            for (int i = aux.Length-1; i >=0; i--)
            {
                if (aux[i]!=null)
                {
                    s1.Push(aux[i]);
                }
            }
            return s1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            //label4.Visible = true;
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }
    }
    class Nodo//clase nodo
    {
        private string Dato;
        private Nodo siguiente;
        public Nodo()//constructor
        {
            Dato = null;
            siguiente = null;
        }
        public Nodo(string d)//ingreso de datos
        {
            Dato = d;
            siguiente = null;
        }
        public Nodo Siguiente//agrga a siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public string dato//agrega a dato
        {
            get { return Dato; }
            set { Dato = value; }
        }

    }
}

