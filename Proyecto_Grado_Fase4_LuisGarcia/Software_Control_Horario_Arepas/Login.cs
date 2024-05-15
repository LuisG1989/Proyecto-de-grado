using Software_Control_Horario_Arepas.Models;
using System.Drawing.Imaging;

namespace Software_Control_Horario_Arepas
{
    public partial class Login : Form
    {
        string paswordOp = "Op123";
        string paswordSup = "Sup123";
        string paswordDom = "Dom123";
        List<Empleado> empleados = new List<Empleado>();
        public Login()
        {
            InitializeComponent();
            CargarUsuariosPrincipales();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = ChangeOpacity(this.BackgroundImage, 0.3F);
        }



        public static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();   // Releasing all resource used by graphics 
            return bmp;
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {

            Empleado empleado = empleados.FirstOrDefault(u => u.documentoEmpleado.ToString() == user.Text);
            if (empleado == null)
            {
                MessageBox.Show("Usuario Incorrecto");
                user.Clear();
                user.Focus();
                return;
            }
            if (password.Text != paswordOp && password.Text != paswordDom && password.Text != paswordSup)
            {
                MessageBox.Show("Contraseña Incorrecta");
                password.Clear();
                password.Focus();
                return;
            }

          
            switch (empleado.tipoEmpleado)
            {
                case "Operario":
                    if(password.Text == "Op123")
                    {
                        Menu menu = new Menu(empleado.documentoEmpleado,ref empleados);
                        this.Hide();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta");
                        password.Clear();
                        password.Focus();
                        return;
                    }
                    break;
                case "Domiciliario":
                    if (password.Text == "Dom123")
                    {
                        Menu menu = new Menu(empleado.documentoEmpleado,ref empleados);
                        this.Hide();
                        menu.Show();

                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta");
                        password.Clear();
                        password.Focus();
                        return;
                    }
                    break;
                case "Supervisor":
                    if (password.Text == "Sup123")
                    {
                        Menu menu = new Menu(empleado.documentoEmpleado,ref empleados);
                        this.Hide();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta");
                        password.Clear();
                        password.Focus();
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("Ususario Incorrecto");
                    password.Clear();
                    password.Focus();
                    return;
            }
        }

        public void CargarUsuariosPrincipales()
        {
            Empleado operario = new Empleado();
            operario.nombreEmpleado = "Yenifer Guzmán";
            operario.tipoEmpleado = "Operario";
            operario.documentoEmpleado = 1018436843;
            operario.fechaIngreso = new DateTime(2024,01,15);

            Empleado domiciliario = new Empleado();
            domiciliario.nombreEmpleado = "Jota García";
            domiciliario.tipoEmpleado = "Domiciliario";
            domiciliario.documentoEmpleado = 1007645728;
            domiciliario.fechaIngreso = new DateTime(2024, 01, 01);

            Empleado supervisor = new Empleado();
            supervisor.nombreEmpleado = "Luis García";
            supervisor.tipoEmpleado = "Supervisor";
            supervisor.documentoEmpleado = 1037597069;
            supervisor.fechaIngreso = new DateTime(2023, 01, 01);

            empleados.Add(operario);
            empleados.Add(domiciliario);
            empleados.Add(supervisor);

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