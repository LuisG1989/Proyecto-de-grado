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
    public partial class CrearPedidos : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Pedido> pedidos = new List<Pedido>();
        int docEmpleado;
        public CrearPedidos(List<Empleado> empleadosList, ref List<Pedido> pedidosList, int docEmpl)
        {
            InitializeComponent();
            this.empleados = empleadosList;
            this.pedidos = pedidosList;
            this.docEmpleado = docEmpl;
            LimpiarDatos();
        }

        public void LimpiarDatos()
        {
            this.Empresas.Items.Add("Éxito");
            this.Empresas.Items.Add("Surtimax");
            this.Empresas.Items.Add("Olímpica");
            this.Empresas.Items.Add("Carulla");
            this.Empresas.Items.Add("Placita de Capri");

            foreach(Empleado empl in empleados.Where(e=>e.tipoEmpleado == "domiciliario"))
            {
                this.Domiciliarios.Items.Add(empl.nombreEmpleado);
            }


        }

        private void CrearPedidos_Load(object sender, EventArgs e)
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

        private void crearPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.fechaPedido = fechaPedido.Text;
            pedido.domiciliario = Domiciliarios.Text;
            pedido.empresa = Empresas.Text;
            pedidos.Add(pedido);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(docEmpleado,ref empleados);
            menu.Show();
            this.Hide();
        }
    }
}
