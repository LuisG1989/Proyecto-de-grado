namespace Software_Control_Horario_Arepas
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.registrarIngreso = new System.Windows.Forms.Button();
            this.RegistrarSalida = new System.Windows.Forms.Button();
            this.ConsutarPedido = new System.Windows.Forms.Button();
            this.CrearEmpleado = new System.Windows.Forms.Button();
            this.CrearPedido = new System.Windows.Forms.Button();
            this.ConsultarEmpleados = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(408, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÚ";
            // 
            // registrarIngreso
            // 
            this.registrarIngreso.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.registrarIngreso.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrarIngreso.Location = new System.Drawing.Point(361, 75);
            this.registrarIngreso.Name = "registrarIngreso";
            this.registrarIngreso.Size = new System.Drawing.Size(153, 29);
            this.registrarIngreso.TabIndex = 2;
            this.registrarIngreso.Text = "Registrar Entrada";
            this.registrarIngreso.UseVisualStyleBackColor = false;
            this.registrarIngreso.Click += new System.EventHandler(this.registrarIngreso_Click);
            // 
            // RegistrarSalida
            // 
            this.RegistrarSalida.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.RegistrarSalida.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegistrarSalida.Location = new System.Drawing.Point(361, 145);
            this.RegistrarSalida.Name = "RegistrarSalida";
            this.RegistrarSalida.Size = new System.Drawing.Size(153, 29);
            this.RegistrarSalida.TabIndex = 3;
            this.RegistrarSalida.Text = "Registrar Salida";
            this.RegistrarSalida.UseVisualStyleBackColor = false;
            this.RegistrarSalida.Click += new System.EventHandler(this.RegistrarSalida_Click);
            // 
            // ConsutarPedido
            // 
            this.ConsutarPedido.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ConsutarPedido.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConsutarPedido.Location = new System.Drawing.Point(361, 215);
            this.ConsutarPedido.Name = "ConsutarPedido";
            this.ConsutarPedido.Size = new System.Drawing.Size(153, 29);
            this.ConsutarPedido.TabIndex = 4;
            this.ConsutarPedido.Text = "Consultar Pedidos";
            this.ConsutarPedido.UseVisualStyleBackColor = false;
            this.ConsutarPedido.Click += new System.EventHandler(this.ConsutarPedido_Click);
            // 
            // CrearEmpleado
            // 
            this.CrearEmpleado.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.CrearEmpleado.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CrearEmpleado.Location = new System.Drawing.Point(361, 110);
            this.CrearEmpleado.Name = "CrearEmpleado";
            this.CrearEmpleado.Size = new System.Drawing.Size(153, 29);
            this.CrearEmpleado.TabIndex = 5;
            this.CrearEmpleado.Text = "Crear Empleado";
            this.CrearEmpleado.UseVisualStyleBackColor = false;
            this.CrearEmpleado.Click += new System.EventHandler(this.CrearEmpleado_Click);
            // 
            // CrearPedido
            // 
            this.CrearPedido.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.CrearPedido.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CrearPedido.Location = new System.Drawing.Point(361, 180);
            this.CrearPedido.Name = "CrearPedido";
            this.CrearPedido.Size = new System.Drawing.Size(153, 29);
            this.CrearPedido.TabIndex = 6;
            this.CrearPedido.Text = "Crear Pedido";
            this.CrearPedido.UseVisualStyleBackColor = false;
            this.CrearPedido.Click += new System.EventHandler(this.CrearPedido_Click);
            // 
            // ConsultarEmpleados
            // 
            this.ConsultarEmpleados.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ConsultarEmpleados.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConsultarEmpleados.Location = new System.Drawing.Point(345, 250);
            this.ConsultarEmpleados.Name = "ConsultarEmpleados";
            this.ConsultarEmpleados.Size = new System.Drawing.Size(187, 29);
            this.ConsultarEmpleados.TabIndex = 8;
            this.ConsultarEmpleados.Text = "Consultar Empleados";
            this.ConsultarEmpleados.UseVisualStyleBackColor = false;
            this.ConsultarEmpleados.Click += new System.EventHandler(this.ConsultarEmpleados_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.OrangeRed;
            this.Salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Salir.Location = new System.Drawing.Point(477, 368);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(151, 42);
            this.Salir.TabIndex = 10;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back.Location = new System.Drawing.Point(261, 368);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(151, 42);
            this.Back.TabIndex = 9;
            this.Back.Text = "Atrás";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 565);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ConsultarEmpleados);
            this.Controls.Add(this.CrearPedido);
            this.Controls.Add(this.CrearEmpleado);
            this.Controls.Add(this.ConsutarPedido);
            this.Controls.Add(this.RegistrarSalida);
            this.Controls.Add(this.registrarIngreso);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "MenuDomiciliario";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button registrarIngreso;
        private Button RegistrarSalida;
        private Button ConsutarPedido;
        private Button CrearEmpleado;
        private Button CrearPedido;
        private Button ConsultarEmpleados;
        private Button Salir;
        private Button Back;
    }
}