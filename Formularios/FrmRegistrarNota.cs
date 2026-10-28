using System;
using System.Windows.Forms;

namespace SistemaRegistroNotas
{
    public partial class FrmRegistrarNota : Form
    {
        private RepositorioGenerico repositorio = new RepositorioGenerico();

        public FrmRegistrarNota()
        {
            InitializeComponent();
            CargarGrid();
        }

        private void CargarGrid()
        {
            try
            {
                dgvRegistro.DataSource = repositorio.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCodigo.Clear();
            txtLaboratorio.Clear();
            txtParcial.Clear();
            txtAsistencia.Clear();
            txtNombre.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // 1. Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtLaboratorio.Text) ||
                string.IsNullOrWhiteSpace(txtParcial.Text) ||
                string.IsNullOrWhiteSpace(txtAsistencia.Text))
            {
                MessageBox.Show("Completa todos los campos antes de guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar rangos de notas (0.0 a 10.0)
            if (!decimal.TryParse(txtLaboratorio.Text, out decimal lab) || lab < 0 || lab > 10 ||
                !decimal.TryParse(txtParcial.Text, out decimal parcial) || parcial < 0 || parcial > 10 ||
                !decimal.TryParse(txtAsistencia.Text, out decimal asistencia) || asistencia < 0 || asistencia > 10)
            {
                MessageBox.Show("Las notas deben ser números entre 0.0 y 10.0", "Nota inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Conversión automática a mayúsculas
            string nombre = txtNombre.Text.ToUpperInvariant();
            string apellido = txtApellido.Text.ToUpperInvariant();
            string codigo = txtCodigo.Text.ToUpperInvariant();

            // 4. Calcular nota final automáticamente (Lab 50%, Parcial 40%, Asistencia 10%)
            decimal notaFinal = Math.Round((lab * 0.50m) + (parcial * 0.40m) + (asistencia * 0.10m), 2);

            try
            {
                // 5. Guardar usando el repositorio
                var nuevoEstudiante = new EstudianteNota
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Codigo = codigo,
                    Laboratorio = lab,
                    Parcial = parcial,
                    Asistencia = asistencia,
                    NotaFinal = notaFinal
                };

                repositorio.InsertarEstudiante(nuevoEstudiante);
                MessageBox.Show("Estudiante guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrid();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible guardar el registro:\n\n" + ex.Message, "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}