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
            ListarClientes();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
            limpiarCampos();

        }

        private bool IngresarCliente()
        {
            try
            {
                nuevoCliente = new Cliente();

                nuevoCliente.nombre = txtNombre.Text;
                nuevoCliente.apellido = txtApellido.Text;
                nuevoCliente.direccion = txtDireccion.Text;
                nuevoCliente.email = txtEmail.Text;
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
            if (IngresarCliente())
            {
                MessageBox.Show("Cliente ingresado con exito");
                ListarClientes();
                limpiarCampos();
            }
            else
            { MessageBox.Show("Cliente no ingresado"); }

        }
        private void limpiarCampos()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            chkEstado.Checked = false;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
