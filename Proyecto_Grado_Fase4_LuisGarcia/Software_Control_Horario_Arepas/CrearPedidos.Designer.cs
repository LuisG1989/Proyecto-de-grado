namespace Software_Control_Horario_Arepas
{
    partial class CrearPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearPedidos));
            this.label1 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Empresas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.crearPedido = new System.Windows.Forms.Button();
            this.fechaPedido = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Domiciliarios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "CREAR PEDIDOS";
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.OrangeRed;
            this.Salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Salir.Location = new System.Drawing.Point(637, 364);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(151, 42);
            this.Salir.TabIndex = 12;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back.Location = new System.Drawing.Point(87, 364);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(151, 42);
            this.Back.TabIndex = 11;
            this.Back.Text = "Atrás";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Empresas
            // 
            this.Empresas.FormattingEnabled = true;
            this.Empresas.Location = new System.Drawing.Point(327, 76);
            this.Empresas.Name = "Empresas";
            this.Empresas.Size = new System.Drawing.Size(151, 28);
            this.Empresas.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(194, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(218, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha";
            // 
            // crearPedido
            // 
            this.crearPedido.BackColor = System.Drawing.Color.Goldenrod;
            this.crearPedido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.crearPedido.Location = new System.Drawing.Point(325, 247);
            this.crearPedido.Name = "crearPedido";
            this.crearPedido.Size = new System.Drawing.Size(151, 42);
            this.crearPedido.TabIndex = 16;
            this.crearPedido.Text = "Crear";
            this.crearPedido.UseVisualStyleBackColor = false;
            this.crearPedido.Click += new System.EventHandler(this.crearPedido_Click);
            // 
            // fechaPedido
            // 
            this.fechaPedido.Location = new System.Drawing.Point(327, 142);
            this.fechaPedido.Name = "fechaPedido";
            this.fechaPedido.Size = new System.Drawing.Size(250, 27);
            this.fechaPedido.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(167, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Domiciliario";
            // 
            // Domiciliarios
            // 
            this.Domiciliarios.FormattingEnabled = true;
            this.Domiciliarios.Location = new System.Drawing.Point(325, 189);
            this.Domiciliarios.Name = "Domiciliarios";
            this.Domiciliarios.Size = new System.Drawing.Size(151, 28);
            this.Domiciliarios.TabIndex = 19;
            // 
            // CrearPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Domiciliarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fechaPedido);
            this.Controls.Add(this.crearPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Empresas);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Name = "CrearPedidos";
            this.Text = "CrearPedidos";
            this.Load += new System.EventHandler(this.CrearPedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Salir;
        private Button Back;
        private ComboBox Empresas;
        private Label label2;
        private Label label3;
        private Button crearPedido;
        private DateTimePicker fechaPedido;
        private Label label4;
        private ComboBox Domiciliarios;
    }
}