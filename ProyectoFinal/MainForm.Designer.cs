namespace ProyectoFinal
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultadDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosultaDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNivel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.aboutByToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(23, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesionToolStripMenuItem.Image")));
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesionToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeUsuariosToolStripMenuItem,
            this.registroDeClientesToolStripMenuItem,
            this.registroDeProductosToolStripMenuItem,
            this.registroDeCategoriasToolStripMenuItem,
            this.registroDeVentasToolStripMenuItem});
            this.registrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrosToolStripMenuItem.Image")));
            this.registrosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroDeUsuariosToolStripMenuItem
            // 
            this.registroDeUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeUsuariosToolStripMenuItem.Image")));
            this.registroDeUsuariosToolStripMenuItem.Name = "registroDeUsuariosToolStripMenuItem";
            this.registroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registroDeUsuariosToolStripMenuItem.Text = "Registro de Usuarios";
            this.registroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeUsuariosToolStripMenuItem_Click);
            // 
            // registroDeClientesToolStripMenuItem
            // 
            this.registroDeClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeClientesToolStripMenuItem.Image")));
            this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
            this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registroDeClientesToolStripMenuItem.Text = "Registro de Clientes";
            this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeClientesToolStripMenuItem_Click);
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeProductosToolStripMenuItem.Image")));
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registroDeProductosToolStripMenuItem.Text = "Registro de Productos";
            this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeProductosToolStripMenuItem_Click);
            // 
            // registroDeCategoriasToolStripMenuItem
            // 
            this.registroDeCategoriasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeCategoriasToolStripMenuItem.Image")));
            this.registroDeCategoriasToolStripMenuItem.Name = "registroDeCategoriasToolStripMenuItem";
            this.registroDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registroDeCategoriasToolStripMenuItem.Text = "Registro de Categorias";
            this.registroDeCategoriasToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeCategoriasToolStripMenuItem_Click);
            // 
            // registroDeVentasToolStripMenuItem
            // 
            this.registroDeVentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeVentasToolStripMenuItem.Image")));
            this.registroDeVentasToolStripMenuItem.Name = "registroDeVentasToolStripMenuItem";
            this.registroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registroDeVentasToolStripMenuItem.Text = "Registro de Ventas";
            this.registroDeVentasToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeVentasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeUsuariosToolStripMenuItem,
            this.consultadDeClientesToolStripMenuItem,
            this.consultaDeProductosToolStripMenuItem,
            this.cosultaDeCategoriasToolStripMenuItem,
            this.consultaDeVentasToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasToolStripMenuItem.Image")));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeUsuariosToolStripMenuItem
            // 
            this.consultaDeUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaDeUsuariosToolStripMenuItem.Image")));
            this.consultaDeUsuariosToolStripMenuItem.Name = "consultaDeUsuariosToolStripMenuItem";
            this.consultaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.consultaDeUsuariosToolStripMenuItem.Text = "Consulta de Usuarios";
            this.consultaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.ConsultaDeUsuariosToolStripMenuItem_Click);
            // 
            // consultadDeClientesToolStripMenuItem
            // 
            this.consultadDeClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultadDeClientesToolStripMenuItem.Image")));
            this.consultadDeClientesToolStripMenuItem.Name = "consultadDeClientesToolStripMenuItem";
            this.consultadDeClientesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.consultadDeClientesToolStripMenuItem.Text = "Consulta de Clientes";
            this.consultadDeClientesToolStripMenuItem.Click += new System.EventHandler(this.ConsultadDeClientesToolStripMenuItem_Click);
            // 
            // consultaDeProductosToolStripMenuItem
            // 
            this.consultaDeProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaDeProductosToolStripMenuItem.Image")));
            this.consultaDeProductosToolStripMenuItem.Name = "consultaDeProductosToolStripMenuItem";
            this.consultaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.consultaDeProductosToolStripMenuItem.Text = "Consulta de Productos";
            this.consultaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.ConsultaDeProductosToolStripMenuItem_Click);
            // 
            // cosultaDeCategoriasToolStripMenuItem
            // 
            this.cosultaDeCategoriasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cosultaDeCategoriasToolStripMenuItem.Image")));
            this.cosultaDeCategoriasToolStripMenuItem.Name = "cosultaDeCategoriasToolStripMenuItem";
            this.cosultaDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cosultaDeCategoriasToolStripMenuItem.Text = "Consulta de Categorias";
            this.cosultaDeCategoriasToolStripMenuItem.Click += new System.EventHandler(this.CosultaDeCategoriasToolStripMenuItem_Click);
            // 
            // consultaDeVentasToolStripMenuItem
            // 
            this.consultaDeVentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaDeVentasToolStripMenuItem.Image")));
            this.consultaDeVentasToolStripMenuItem.Name = "consultaDeVentasToolStripMenuItem";
            this.consultaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.consultaDeVentasToolStripMenuItem.Text = "Consulta de Ventas";
            this.consultaDeVentasToolStripMenuItem.Click += new System.EventHandler(this.ConsultaDeVentasToolStripMenuItem_Click);
            // 
            // aboutByToolStripMenuItem
            // 
            this.aboutByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem});
            this.aboutByToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutByToolStripMenuItem.Image")));
            this.aboutByToolStripMenuItem.Name = "aboutByToolStripMenuItem";
            this.aboutByToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.aboutByToolStripMenuItem.Text = "Ayuda";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("autorToolStripMenuItem.Image")));
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.autorToolStripMenuItem.Text = "Acerca de";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.AutorToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(23, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(917, 473);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelUsuario,
            this.toolStripStatusLabelNivel,
            this.toolStripStatusLabelFecha});
            this.statusStrip1.Location = new System.Drawing.Point(23, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelUsuario
            // 
            this.statusLabelUsuario.Name = "statusLabelUsuario";
            this.statusLabelUsuario.Size = new System.Drawing.Size(106, 17);
            this.statusLabelUsuario.Text = "statusLabelUsuario";
            // 
            // toolStripStatusLabelNivel
            // 
            this.toolStripStatusLabelNivel.Name = "toolStripStatusLabelNivel";
            this.toolStripStatusLabelNivel.Size = new System.Drawing.Size(139, 17);
            this.toolStripStatusLabelNivel.Text = "toolStripStatusLabelNivel";
            // 
            // toolStripStatusLabelFecha
            // 
            this.toolStripStatusLabelFecha.Name = "toolStripStatusLabelFecha";
            this.toolStripStatusLabelFecha.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1001;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MainForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 572);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Text = "SISTEMA DE VENTAS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultadDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosultaDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelUsuario;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNivel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFecha;
        private System.Windows.Forms.Timer timer1;
    }
}

