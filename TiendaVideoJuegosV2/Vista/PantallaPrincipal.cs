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

    
        private TJuego RecogerDatosPantalla()
        {
            TJuego juego=null;
            string titulo, compania,categoria, precio, formatoUno, formatoDos, estado;
            titulo = txtTitulo.Text;
            compania = txtCompania.Text;
            precio = txt_Precio.Text.Replace(".", ",");
            precio = precio.Replace("€", "");
            precio = precio.Trim();
            formatoDos = chkBox_Digital.Checked ? chkBox_Digital.Text : "N/A";
            formatoUno = chkBox_Fisico.Checked ? chkBox_Fisico.Text : "N/A";
            categoria = cbBox_Categoria.SelectedItem.ToString();
            //categoria = cbBox_Categoria.SelectedItem.ToString();
            if (rb_Nuevo.Checked)
            {
                estado = "nuevo";
            }
            else
            {
                estado = "seminuevo";
            }

            if (titulo.Count() != 0 && precio.Count() != 0)
            {
                juego = new TJuego(titulo, compania,categoria, precio, formatoUno, formatoDos, estado);
            }
            return juego;
        }
        private void EnviarDatosAPantalla(TJuego juego)
        {
            txtTitulo.Text = juego.Titulo;
            txtCompania.Text = juego.Compania;
            txt_Precio.Text = juego.Precio;
            if (juego.Estado.Equals("nuevo"))
            {
                rb_Nuevo.Checked = true;
                rb_Seminuevo.Checked = false;
            }
            else
            {
                rb_Nuevo.Checked = false;
                rb_Seminuevo.Checked = true;
            }
            chkBox_Fisico.Checked = juego.Formatouno.Equals("Fisico") ? true : false;
            chkBox_Digital.Checked = juego.Formatodos.Equals("Digital") ? true : false;
            
        }

        private void VaciarPantalla()
        {
            txtTitulo.Text = "";
            txtCompania.Text = "";
            txt_Precio.Text = "";
            rb_Nuevo.Checked = false;
            rb_Seminuevo.Checked = false;
            chkBox_Digital.Checked = false;
            chkBox_Fisico.Checked = false;
            cbBox_Categoria.SelectedIndex = 0;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            VaciarPantalla();
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                if (acceso.insertarJuego(RecogerDatosPantalla()))
                {
                    lst_Box.Items.Add(txtTitulo.Text);
                    MessageBox.Show(Mensajes.MSG_INSERTADO);
                }
                else
                {
                    MessageBox.Show(Mensajes.MSG_YAEXISTE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(lst_Box.SelectedIndex == -1))
                {
                    if (acceso.borrarJuego(RecogerDatosPantalla()))
                    {
                        lst_Box.Items.Remove(lst_Box.SelectedItem.ToString());
                        MessageBox.Show(Mensajes.MSG_BORRADO);
                    }
                    else
                    {
                        MessageBox.Show(Mensajes.MSG_NO_ENCONTRADO);
                    }
                    VaciarPantalla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            String titulo = lst_Box.SelectedItem.ToString();
            try
            {
                if (acceso.modificarJuego(RecogerDatosPantalla(), titulo))
                {
                    MessageBox.Show(Mensajes.MSG_MODIFICADO);
                }
                else
                {
                    MessageBox.Show(Mensajes.MSG_NO_ENCONTRADO);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lst_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lst_Box.SelectedItem != null)
                {
                    EnviarDatosAPantalla((TJuego)acceso.buscarJuego(lst_Box.SelectedItem.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }


        private void cbBox_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
