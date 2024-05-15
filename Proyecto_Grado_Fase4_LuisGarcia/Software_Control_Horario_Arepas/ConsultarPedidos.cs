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
    public partial class ConsultarPedidos : Form
    {
        List<Pedido> pedidos = new List<Pedido>();
        List<Empleado> emplList = new List<Empleado>();
        Empleado empleado1 = new Empleado();
        string nombreEmpleado;
        int docEmpleado;
        public ConsultarPedidos(string empleado, ref List<Pedido> pedidosList, List<Empleado> empleados)
        {
            InitializeComponent();
            this.pedidos = pedidosList;
            this.emplList = empleados;
            this.nombreEmpleado = empleado;
            empleado1 = empleados.FirstOrDefault(e => e.nombreEmpleado == empleado);
            this.docEmpleado = empleado1.documentoEmpleado;
            CargarPedidosPrueba();
        }

        private void ConsultarPedidos_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Login.ChangeOpacity(this.BackgroundImage, 0.3F);
        }
        public void CargarPedidosPrueba()
        {
            Pedido pedido = new Pedido();
            pedido.fechaPedido = DateTime.Now.ToShortDateString();
            pedido.empresa = "Éxito";
            pedido.domiciliario = "Jota García";

            Pedido pedido2 = new Pedido();
            pedido.fechaPedido = DateTime.Now.ToShortDateString();
            pedido.empresa = "Surtimax";
            pedido.domiciliario = "Jota García";

            Pedido pedido3 = new Pedido();
            pedido.fechaPedido = DateTime.Now.ToShortDateString();
            pedido.empresa = "Carulla";
            pedido.domiciliario = "Jota García";

            this.pedidos.Add(pedido);
            this.pedidos.Add(pedido2);
            this.pedidos.Add(pedido3);
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void consultar_Click(object sender, EventArgs e)
        {
            if (empleado1.tipoEmpleado == "Supervisor")
            {
                this.dgPedidos.DataSource = null;
                this.dgPedidos.DataSource = pedidos;
            }
            else
            {
                this.dgPedidos.DataSource = null;
                this.dgPedidos.DataSource = pedidos.Where(p=>p.domiciliario == nombreEmpleado);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(docEmpleado, ref emplList);
            menu.Show();
            this.Hide();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
