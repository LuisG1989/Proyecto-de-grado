using Software_Control_Horario_Arepas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Control_Horario_Arepas
{
    public partial class AgregarEmpleado : Form
    {
        List<Empleado> empleadosList = new List<Empleado>();
        readonly int docEmpleado = 0;
        public AgregarEmpleado(int docEmpleado, ref List<Empleado> empleados)
        {
            InitializeComponent();
            this.docEmpleado = docEmpleado;
            empleadosList = empleados;

            this.tipoEmpleado.Items.Add("Operario");
            this.tipoEmpleado.Items.Add("Domiciliario");
            this.tipoEmpleado.Items.Add("Supervisor");
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Login.ChangeOpacity(this.BackgroundImage, 0.3F);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void crearEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.nombreEmpleado = nombreEmpleado.Text;
            empleado.documentoEmpleado =  Convert.ToInt32(documento.Text);
            empleado.fechaIngreso = DateTime.Now;
            empleado.tipoEmpleado = tipoEmpleado.Text.Trim();
            empleadosList.Add(empleado);
            MessageBox.Show("Empleado registrado correctamente", "Registro", MessageBoxButtons.OK);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(docEmpleado, ref empleadosList);
            menu.Show();
            this.Hide();
        }
    }
}
