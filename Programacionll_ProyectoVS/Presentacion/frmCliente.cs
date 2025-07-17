using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programacionll_ProyectoVS.AccesoDatos.Entidades;
using Programacionll_ProyectoVS.LogicaNegocio;

namespace Programacionll_ProyectoVS.Presentacion
{
    public partial class frmCliente : Form
    {
        private ClienteLogica clienteLogica;
        private Cliente nuevoCliente;
        public frmCliente()
        {
            InitializeComponent();
            clienteLogica = new ClienteLogica();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();

        }

        private bool IngresarCliente()
        {
            try
            {
                nuevoCliente = new Cliente();

                nuevoCliente.nombre = textNombre.Text;
                nuevoCliente.apellido = textApellido.Text;
                nuevoCliente.direccion = textDireccion.Text;
                nuevoCliente.email = textEmail.Text;
                if (chkEstado.Checked)
                    nuevoCliente.estado = 1; //activo
                else nuevoCliente.estado = 0; //inactivo

                return clienteLogica.InsertarCliente(nuevoCliente);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void ListarClientes()
        {
            dgvClientes.DataSource = clienteLogica.DataListarCliente();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (IngresarCliente()) {
                MessageBox.Show("Cliente ingresado con exito");
                ListarClientes();
            } else
            { MessageBox.Show("Cliente no ingresado"); }

        }

        private void limpiarCampos()
        {
            textApellido = " "; 
        }
    } }
