using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Software_Control_Horario_Arepas
{
    public partial class Menu : Form
    {
        Empleado empleado = new Empleado();
        List<Empleado> empleadosList = new List<Empleado>();
        List<Pedido> pedidosList = new List<Pedido>();
        int docEmpleado = 0;
        public Menu(int documentoEmpleado,ref List<Empleado> empleados)
        {
            InitializeComponent();
            docEmpleado = documentoEmpleado;
            this.empleadosList = empleados;
            empleado = empleados.FirstOrDefault(u => u.documentoEmpleado == documentoEmpleado);
            switch (empleado.tipoEmpleado)
            {
                case "Operario":
                    registrarIngreso.Visible = true;
                    RegistrarSalida.Visible = true;
                    ConsultarEmpleados.Visible = false;
                    ConsutarPedido.Visible = false;
                    CrearEmpleado.Visible = false;
                    CrearPedido.Visible = false;
                    break;
                case "Domiciliario":
                    registrarIngreso.Visible = true;
                    ConsultarEmpleados.Visible = false;
                    ConsutarPedido.Visible = true;
                    CrearEmpleado.Visible = false;
                    CrearPedido.Visible = false;
                    break;
                case "Supervisor":
                    registrarIngreso.Visible = true;
                    RegistrarSalida.Visible = true;
                    ConsultarEmpleados.Visible = true;
                    ConsutarPedido.Visible = true;
                    CrearEmpleado.Visible = true;
                    CrearPedido.Visible = true;
                    break;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
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

        private void registrarIngreso_Click(object sender, EventArgs e)
        {
            empleado.registroIngresoSalidas = new List<IngresoSalida>();
            empleado.registroIngresoSalidas.Add(new IngresoSalida { fechaIngreso = DateTime.Now });
        }

        private void RegistrarSalida_Click(object sender, EventArgs e)
        {
            empleado.registroIngresoSalidas = new List<IngresoSalida>();
            empleado.registroIngresoSalidas.Add(new IngresoSalida { fechaSalida = DateTime.Now });
        }

        private void CrearPedido_Click(object sender, EventArgs e)
        {

        }

        private void ConsutarPedido_Click(object sender, EventArgs e)
        {
            ConsultarPedidos consultar = new ConsultarPedidos(empleado.nombreEmpleado, ref pedidosList, empleadosList);
            consultar.Show();
            this.Hide();
        }

        private void CrearEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleado CrearEmpleado = new AgregarEmpleado(empleado.documentoEmpleado, ref empleadosList);
            CrearEmpleado.Show();
            this.Hide();
        }

        private void ConsultarEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(docEmpleado, ref empleadosList);
            menu.Show();
            this.Hide();
        }
    }
}
