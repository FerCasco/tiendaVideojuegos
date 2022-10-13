using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaVideoJuegosV2.Datos;
using TiendaVideoJuegosV2.Modelo;

namespace TiendaVideoJuegosV2
{
    public partial class PantallaPrincipal : Form
    {
        
        private AccesoJuego acceso = new AccesoJuego();
        public PantallaPrincipal()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                List<Object> list = acceso.obtenerJuegos();
                foreach (TJuego juego in list)
                {
                    lst_Box.Items.Add(juego);  
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
