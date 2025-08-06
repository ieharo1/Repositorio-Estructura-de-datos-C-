using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_reproductor_de_musica
{
    public partial class Form1 : Form
    {
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;
        public Form1()
        {
            InitializeComponent();
            Diseño();
        }
        public void Diseño()
        {
            panel2.Visible = false;

        }
        public void OcultarPanel()
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }
        public void MostrarPanel(Panel medios)
        {
            if (medios.Visible == false)
            {
                OcultarPanel();
                medios.Visible = true;
            }
            else
            {

                medios.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog lista = new OpenFileDialog();
            lista.Multiselect = true;
            if (lista.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMP3 = lista.SafeFileNames;
                rutasArchivosMP3 = lista.FileNames;
                foreach(var ArchivoMP3 in ArchivosMP3)
                {
                    lstcanciones.Items.Add(ArchivoMP3);
                }
                Reproductor.URL = rutasArchivosMP3[0];
                lstcanciones.SelectedIndex = 0;
            }
        }

        private void Medios_Click(object sender, EventArgs e)
        {

            MostrarPanel(panel2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstcanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lstcanciones_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Reproductor.URL = rutasArchivosMP3[lstcanciones.SelectedIndex];
        }
    }
}
