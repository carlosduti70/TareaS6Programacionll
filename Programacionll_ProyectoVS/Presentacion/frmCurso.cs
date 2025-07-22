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
    public partial class frmCurso : Form
    {
        private CursoLogica cursoLogica;
        private curso nuevoCurso;
        public frmCurso()
        {
            InitializeComponent();
            cursoLogica = new CursoLogica();
            ListarCursos();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ListarCursos();
            limpiarCampos();

        }

        private bool IngresarCurso()
        {
            try
            {
                nuevoCurso = new curso();

                nuevoCurso.nombre = txtNombre.Text;
                nuevoCurso.descripcion = txtDescripcion.Text;
                if (chkEstado.Checked)
                    nuevoCurso.estado = 1; //activo
                else nuevoCurso.estado = 0; //inactivo

                return cursoLogica.InsertarCurso(nuevoCurso);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void ListarCursos()
        {
            dgvCursos.DataSource = cursoLogica.DataListarCurso();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (IngresarCurso())
            {
                MessageBox.Show("Curso ingresado con exito");
                ListarCursos();
                limpiarCampos();
            }
            else
            { MessageBox.Show("Curso no ingresado"); }

        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = false;
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}