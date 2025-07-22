using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programacionll_ProyectoVS.AccesoDatos.DAO;
using Programacionll_ProyectoVS.AccesoDatos.Entidades;
using Programacionll_ProyectoVS.LogicaNegocio;

namespace Programacionll_ProyectoVS.Presentacion
{
    public partial class Inscripcion : Form
    {
        private InscripcionLogica inscripcionLogica;
        private inscripcion nuevaInscripcion;
        public Inscripcion()
        {
            InitializeComponent();
            inscripcionLogica = new InscripcionLogica();
            ListarInscripciones();
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            // Curso
            CursoDAO cursoDao = new CursoDAO();
            DataTable dtCursos = cursoDao.GetListarCursos();
            List<curso> cursos = new List<curso>();

            foreach (DataRow row in dtCursos.Rows)
            {
                cursos.Add(new curso
                {
                    idCurso = Convert.ToInt32(row["id_Curso"]),
                    nombre = row["nombre"].ToString()
                    // agrega otros campos si los necesitas
                });
            }

            cmbCurso.DataSource = cursos;
            cmbCurso.DisplayMember = "nombre";
            cmbCurso.ValueMember = "idCurso";

            // Cliente
            ClienteDAO clienteDao = new ClienteDAO();
            DataTable dtClientes = clienteDao.GetListarCliente();
            List<Cliente> clientes = new List<Cliente>();

            foreach (DataRow row in dtClientes.Rows)
            {
                clientes.Add(new Cliente
                {
                    idCliente = Convert.ToInt32(row["id_Cliente"]),
                    nombre = row["nombre"].ToString()
                    // agrega otros campos si los necesitas
                });
            }

            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "nombre";
            cmbCliente.ValueMember = "idCliente";
        }


        private bool IngresarInscripcion()
        {
            try
            {
                nuevaInscripcion = new inscripcion();

                // Fecha actual del sistema
                nuevaInscripcion.fechaInscripcion = DateTime.Now;

                // ID del curso seleccionado desde el ComboBox
                nuevaInscripcion.FK_Curso = Convert.ToInt32(cmbCurso.SelectedValue);

                // ID del cliente seleccionado desde el ComboBox
                nuevaInscripcion.FK_Cliente = Convert.ToInt32(cmbCliente.SelectedValue);

                if (chkEstado.Checked)
                    nuevaInscripcion.estado = 1; //activo
                else nuevaInscripcion.estado = 0; //inactivo

                return inscripcionLogica.InsertarInscripcion(nuevaInscripcion);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (IngresarInscripcion())
            {
                MessageBox.Show("Curso ingresado con exito");
                ListarInscripciones();
            }
            else
            { MessageBox.Show("Curso no ingresado"); }
        }

        private void ListarInscripciones()
        {
            dgvCursos.DataSource = inscripcionLogica.DataListarInscripcion();
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
