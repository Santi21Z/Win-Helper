namespace Win_Helper
{
    partial class Form_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            this.Barra_Titulo = new System.Windows.Forms.Panel();
            this.Boton_Minimizar = new System.Windows.Forms.PictureBox();
            this.Boton_Cerrar = new System.Windows.Forms.PictureBox();
            this.Menu_Vertical_Izquierdo = new System.Windows.Forms.Panel();
            this.Contribuciones = new System.Windows.Forms.Button();
            this.DesactivarWindows = new System.Windows.Forms.Button();
            this.ActivarWindows_Menu = new System.Windows.Forms.Button();
            this.Logo_inicial = new System.Windows.Forms.PictureBox();
            this.Ver_Version_Windows = new System.Windows.Forms.Button();
            this.windows_10_home = new System.Windows.Forms.Button();
            this.windows_10_pro = new System.Windows.Forms.Button();
            this.windows_10_education = new System.Windows.Forms.Button();
            this.windows_10_single = new System.Windows.Forms.Button();
            this.windows_10_enterprise = new System.Windows.Forms.Button();
            this.windows_10_enterpriseN = new System.Windows.Forms.Button();
            this.windows_10_homeN = new System.Windows.Forms.Button();
            this.windows_10_proN = new System.Windows.Forms.Button();
            this.windows_10_educationN = new System.Windows.Forms.Button();
            this.Mensaje_Bienvenida = new System.Windows.Forms.PictureBox();
            this.Mensaje_Carga = new System.Windows.Forms.PictureBox();
            this.gif_carga = new System.Windows.Forms.PictureBox();
            this.informacion = new System.Windows.Forms.Button();
            this.Barra_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Boton_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boton_Cerrar)).BeginInit();
            this.Menu_Vertical_Izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_inicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mensaje_Bienvenida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mensaje_Carga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gif_carga)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_Titulo
            // 
            this.Barra_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Barra_Titulo.Controls.Add(this.Boton_Minimizar);
            this.Barra_Titulo.Controls.Add(this.Boton_Cerrar);
            this.Barra_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Barra_Titulo.Name = "Barra_Titulo";
            this.Barra_Titulo.Size = new System.Drawing.Size(862, 35);
            this.Barra_Titulo.TabIndex = 0;
            this.Barra_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_Titulo_MouseDown);
            // 
            // Boton_Minimizar
            // 
            this.Boton_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Minimizar.Image")));
            this.Boton_Minimizar.Location = new System.Drawing.Point(794, 0);
            this.Boton_Minimizar.Name = "Boton_Minimizar";
            this.Boton_Minimizar.Size = new System.Drawing.Size(30, 35);
            this.Boton_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Boton_Minimizar.TabIndex = 4;
            this.Boton_Minimizar.TabStop = false;
            this.Boton_Minimizar.Click += new System.EventHandler(this.Boton_Minimizar_Click);
            // 
            // Boton_Cerrar
            // 
            this.Boton_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Cerrar.Image")));
            this.Boton_Cerrar.Location = new System.Drawing.Point(829, 0);
            this.Boton_Cerrar.Name = "Boton_Cerrar";
            this.Boton_Cerrar.Size = new System.Drawing.Size(30, 35);
            this.Boton_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Boton_Cerrar.TabIndex = 2;
            this.Boton_Cerrar.TabStop = false;
            this.Boton_Cerrar.Click += new System.EventHandler(this.Boton_Cerrar_Click);
            // 
            // Menu_Vertical_Izquierdo
            // 
            this.Menu_Vertical_Izquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.Menu_Vertical_Izquierdo.Controls.Add(this.informacion);
            this.Menu_Vertical_Izquierdo.Controls.Add(this.Contribuciones);
            this.Menu_Vertical_Izquierdo.Controls.Add(this.DesactivarWindows);
            this.Menu_Vertical_Izquierdo.Controls.Add(this.ActivarWindows_Menu);
            this.Menu_Vertical_Izquierdo.Controls.Add(this.Logo_inicial);
            this.Menu_Vertical_Izquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Vertical_Izquierdo.Location = new System.Drawing.Point(0, 35);
            this.Menu_Vertical_Izquierdo.Name = "Menu_Vertical_Izquierdo";
            this.Menu_Vertical_Izquierdo.Size = new System.Drawing.Size(288, 492);
            this.Menu_Vertical_Izquierdo.TabIndex = 1;
            // 
            // Contribuciones
            // 
            this.Contribuciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Contribuciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contribuciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contribuciones.ForeColor = System.Drawing.Color.White;
            this.Contribuciones.Location = new System.Drawing.Point(57, 422);
            this.Contribuciones.Name = "Contribuciones";
            this.Contribuciones.Size = new System.Drawing.Size(186, 59);
            this.Contribuciones.TabIndex = 3;
            this.Contribuciones.Text = "Contributions";
            this.Contribuciones.UseVisualStyleBackColor = true;
            this.Contribuciones.Click += new System.EventHandler(this.Contribuciones_Click);
            // 
            // DesactivarWindows
            // 
            this.DesactivarWindows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DesactivarWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DesactivarWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesactivarWindows.ForeColor = System.Drawing.Color.White;
            this.DesactivarWindows.Location = new System.Drawing.Point(12, 191);
            this.DesactivarWindows.Name = "DesactivarWindows";
            this.DesactivarWindows.Size = new System.Drawing.Size(262, 59);
            this.DesactivarWindows.TabIndex = 2;
            this.DesactivarWindows.Text = "Deactivate Windows";
            this.DesactivarWindows.UseVisualStyleBackColor = true;
            this.DesactivarWindows.Click += new System.EventHandler(this.DesactivarWindows_Click);
            // 
            // ActivarWindows_Menu
            // 
            this.ActivarWindows_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActivarWindows_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivarWindows_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivarWindows_Menu.ForeColor = System.Drawing.Color.White;
            this.ActivarWindows_Menu.Location = new System.Drawing.Point(12, 116);
            this.ActivarWindows_Menu.Name = "ActivarWindows_Menu";
            this.ActivarWindows_Menu.Size = new System.Drawing.Size(262, 59);
            this.ActivarWindows_Menu.TabIndex = 1;
            this.ActivarWindows_Menu.Text = "Activate Windows";
            this.ActivarWindows_Menu.UseVisualStyleBackColor = true;
            this.ActivarWindows_Menu.Click += new System.EventHandler(this.ActivarWindows_Menu_Click);
            // 
            // Logo_inicial
            // 
            this.Logo_inicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_inicial.Image = ((System.Drawing.Image)(resources.GetObject("Logo_inicial.Image")));
            this.Logo_inicial.Location = new System.Drawing.Point(-6, -26);
            this.Logo_inicial.Name = "Logo_inicial";
            this.Logo_inicial.Size = new System.Drawing.Size(400, 145);
            this.Logo_inicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_inicial.TabIndex = 0;
            this.Logo_inicial.TabStop = false;
            this.Logo_inicial.Click += new System.EventHandler(this.Logo_inicial_Click);
            // 
            // Ver_Version_Windows
            // 
            this.Ver_Version_Windows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ver_Version_Windows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ver_Version_Windows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ver_Version_Windows.ForeColor = System.Drawing.Color.White;
            this.Ver_Version_Windows.Location = new System.Drawing.Point(304, 54);
            this.Ver_Version_Windows.Name = "Ver_Version_Windows";
            this.Ver_Version_Windows.Size = new System.Drawing.Size(541, 79);
            this.Ver_Version_Windows.TabIndex = 4;
            this.Ver_Version_Windows.Text = "Show my Windows Version";
            this.Ver_Version_Windows.UseVisualStyleBackColor = true;
            this.Ver_Version_Windows.Click += new System.EventHandler(this.Ver_Version_Windows_Click);
            // 
            // windows_10_home
            // 
            this.windows_10_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windows_10_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows_10_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_10_home.ForeColor = System.Drawing.Color.White;
            this.windows_10_home.Location = new System.Drawing.Point(304, 151);
            this.windows_10_home.Name = "windows_10_home";
            this.windows_10_home.Size = new System.Drawing.Size(262, 59);
            this.windows_10_home.TabIndex = 4;
            this.windows_10_home.Text = "Windows 10 Home";
            this.windows_10_home.UseVisualStyleBackColor = true;
            this.windows_10_home.Click += new System.EventHandler(this.windows_10_home_Click);
            // 
            // windows_10_pro
            // 
            this.windows_10_pro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windows_10_pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows_10_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_10_pro.ForeColor = System.Drawing.Color.White;
            this.windows_10_pro.Location = new System.Drawing.Point(304, 226);
            this.windows_10_pro.Name = "windows_10_pro";
            this.windows_10_pro.Size = new System.Drawing.Size(262, 59);
            this.windows_10_pro.TabIndex = 5;
            this.windows_10_pro.Text = "Windows 10 Professional";
            this.windows_10_pro.UseVisualStyleBackColor = true;
            this.windows_10_pro.Click += new System.EventHandler(this.windows_10_pro_Click);
            // 
            // windows_10_education
            // 
            this.windows_10_education.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windows_10_education.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows_10_education.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_10_education.ForeColor = System.Drawing.Color.White;
            this.windows_10_education.Location = new System.Drawing.Point(304, 377);
            this.windows_10_education.Name = "windows_10_education";
            this.windows_10_education.Size = new System.Drawing.Size(262, 59);
            this.windows_10_education.TabIndex = 6;
            this.windows_10_education.Text = "Windows 10 Education";
            this.windows_10_education.UseVisualStyleBackColor = true;
            this.windows_10_education.Click += new System.EventHandler(this.windows_10_education_Click);
            // 
            // windows_10_single
            // 
            this.windows_10_single.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windows_10_single.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows_10_single.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_10_single.ForeColor = System.Drawing.Color.White;
            this.windows_10_single.Location = new System.Drawing.Point(304, 457);
            this.windows_10_single.Name = "windows_10_single";
            this.windows_10_single.Size = new System.Drawing.Size(541, 59);
            this.windows_10_single.TabIndex = 7;
            this.windows_10_single.Text = "Windows 10 Single Language";
            this.windows_10_single.UseVisualStyleBackColor = true;
            this.windows_10_single.Click += new System.EventHandler(this.windows_10_single_Click);
            // 
            // windows_10_enterprise
            // 
            this.windows_10_enterprise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windows_10_enterprise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows_10_enterprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_10_enterprise.ForeColor = System.Drawing.Color.White;
            this.windows_10_enterprise.Location = new System.Drawing.Point(304, 303);
            this.windows_10_enterprise.Name = "windows_10_enterprise";
            this.windows_10_enterprise.Size = new System.Drawing.Size(262, 59);
            this.windows_10_enterprise.TabIndex = 8;
            this.windows_10_enterprise.Text = "Windows 10 Enterprise";
            this.windows_10_enterprise.UseVisualStyleBackColor = true;
            this.windows_10_enterprise.Click += new System.EventHandler(this.windows_10_enterprise_Click);
            // 
            // windows_10_enterpriseN
            // 
            this.windows_10_enterpriseN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windows_10_enterpriseN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows_10_enterpriseN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_10_enterpriseN.ForeColor = System.Drawing.Color.White;
            this.windows_10_enterpriseN.Location = new System.Drawing.Point(583, 303);
            this.windows_10_enterpriseN.Name = "windows_10_enterpriseN";
            this.windows_10_enterpriseN.Size = new System.Drawing.Size(262, 59);
            this.windows_10_enterpriseN.TabIndex = 9;
            this.windows_10_enterpriseN.Text = "Windows 10 Enterprise N";
            this.windows_10_enterpriseN.UseVisualStyleBackColor = true;
            this.windows_10_enterpriseN.Click += new System.EventHandler(this.windows_10_enterpriseN_Click);
            // 
            // windows_10_homeN
            // 
            this.windows_10_homeN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windows_10_homeN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows_10_homeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_10_homeN.ForeColor = System.Drawing.Color.White;
            this.windows_10_homeN.Location = new System.Drawing.Point(583, 151);
            this.windows_10_homeN.Name = "windows_10_homeN";
            this.windows_10_homeN.Size = new System.Drawing.Size(262, 59);
            this.windows_10_homeN.TabIndex = 10;
            this.windows_10_homeN.Text = "Windows 10 Home N";
            this.windows_10_homeN.UseVisualStyleBackColor = true;
            this.windows_10_homeN.Click += new System.EventHandler(this.windows_10_homeN_Click);
            // 
            // windows_10_proN
            // 
            this.windows_10_proN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windows_10_proN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows_10_proN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_10_proN.ForeColor = System.Drawing.Color.White;
            this.windows_10_proN.Location = new System.Drawing.Point(585, 226);
            this.windows_10_proN.Name = "windows_10_proN";
            this.windows_10_proN.Size = new System.Drawing.Size(262, 59);
            this.windows_10_proN.TabIndex = 11;
            this.windows_10_proN.Text = "Windows 10 Professional N";
            this.windows_10_proN.UseVisualStyleBackColor = true;
            this.windows_10_proN.Click += new System.EventHandler(this.windows_10_proN_Click);
            // 
            // windows_10_educationN
            // 
            this.windows_10_educationN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windows_10_educationN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows_10_educationN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_10_educationN.ForeColor = System.Drawing.Color.White;
            this.windows_10_educationN.Location = new System.Drawing.Point(583, 377);
            this.windows_10_educationN.Name = "windows_10_educationN";
            this.windows_10_educationN.Size = new System.Drawing.Size(262, 59);
            this.windows_10_educationN.TabIndex = 12;
            this.windows_10_educationN.Text = "Windows 10 Education N";
            this.windows_10_educationN.UseVisualStyleBackColor = true;
            this.windows_10_educationN.Click += new System.EventHandler(this.windows_10_educationN_Click);
            // 
            // Mensaje_Bienvenida
            // 
            this.Mensaje_Bienvenida.Image = ((System.Drawing.Image)(resources.GetObject("Mensaje_Bienvenida.Image")));
            this.Mensaje_Bienvenida.Location = new System.Drawing.Point(283, 35);
            this.Mensaje_Bienvenida.Name = "Mensaje_Bienvenida";
            this.Mensaje_Bienvenida.Size = new System.Drawing.Size(579, 492);
            this.Mensaje_Bienvenida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mensaje_Bienvenida.TabIndex = 4;
            this.Mensaje_Bienvenida.TabStop = false;
            // 
            // Mensaje_Carga
            // 
            this.Mensaje_Carga.Image = ((System.Drawing.Image)(resources.GetObject("Mensaje_Carga.Image")));
            this.Mensaje_Carga.Location = new System.Drawing.Point(283, 35);
            this.Mensaje_Carga.Name = "Mensaje_Carga";
            this.Mensaje_Carga.Size = new System.Drawing.Size(576, 313);
            this.Mensaje_Carga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mensaje_Carga.TabIndex = 4;
            this.Mensaje_Carga.TabStop = false;
            // 
            // gif_carga
            // 
            this.gif_carga.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gif_carga.Location = new System.Drawing.Point(499, 250);
            this.gif_carga.Name = "gif_carga";
            this.gif_carga.Size = new System.Drawing.Size(155, 121);
            this.gif_carga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gif_carga.TabIndex = 4;
            this.gif_carga.TabStop = false;
            // 
            // informacion
            // 
            this.informacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.informacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacion.ForeColor = System.Drawing.Color.White;
            this.informacion.Location = new System.Drawing.Point(12, 266);
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(262, 59);
            this.informacion.TabIndex = 4;
            this.informacion.Text = "Info";
            this.informacion.UseVisualStyleBackColor = true;
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(862, 527);
            this.Controls.Add(this.Mensaje_Bienvenida);
            this.Controls.Add(this.windows_10_educationN);
            this.Controls.Add(this.windows_10_proN);
            this.Controls.Add(this.windows_10_homeN);
            this.Controls.Add(this.windows_10_enterpriseN);
            this.Controls.Add(this.windows_10_enterprise);
            this.Controls.Add(this.windows_10_single);
            this.Controls.Add(this.windows_10_education);
            this.Controls.Add(this.windows_10_pro);
            this.Controls.Add(this.windows_10_home);
            this.Controls.Add(this.Ver_Version_Windows);
            this.Controls.Add(this.Menu_Vertical_Izquierdo);
            this.Controls.Add(this.Barra_Titulo);
            this.Controls.Add(this.Mensaje_Carga);
            this.Controls.Add(this.gif_carga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_principal";
            this.Text = "Form1";
            this.Barra_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Boton_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boton_Cerrar)).EndInit();
            this.Menu_Vertical_Izquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_inicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mensaje_Bienvenida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mensaje_Carga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gif_carga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Titulo;
        private System.Windows.Forms.PictureBox Boton_Minimizar;
        private System.Windows.Forms.PictureBox Boton_Cerrar;
        private System.Windows.Forms.Panel Menu_Vertical_Izquierdo;
        private System.Windows.Forms.PictureBox Logo_inicial;
        private System.Windows.Forms.Button ActivarWindows_Menu;
        private System.Windows.Forms.Button Contribuciones;
        private System.Windows.Forms.Button DesactivarWindows;
        private System.Windows.Forms.Button Ver_Version_Windows;
        private System.Windows.Forms.Button windows_10_home;
        private System.Windows.Forms.Button windows_10_pro;
        private System.Windows.Forms.Button windows_10_education;
        private System.Windows.Forms.Button windows_10_single;
        private System.Windows.Forms.Button windows_10_enterprise;
        private System.Windows.Forms.Button windows_10_enterpriseN;
        private System.Windows.Forms.Button windows_10_homeN;
        private System.Windows.Forms.Button windows_10_proN;
        private System.Windows.Forms.Button windows_10_educationN;
        private System.Windows.Forms.PictureBox Mensaje_Bienvenida;
        private System.Windows.Forms.PictureBox Mensaje_Carga;
        private System.Windows.Forms.PictureBox gif_carga;
        private System.Windows.Forms.Button informacion;
    }
}

