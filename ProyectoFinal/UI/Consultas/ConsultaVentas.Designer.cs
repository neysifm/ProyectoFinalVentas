namespace ProyectoFinal.UI.Consultas
{
    partial class ConsultaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVentas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechacheckBox = new System.Windows.Forms.CheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DesdemetroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.HastametroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.ImprimirmetroButton = new MetroFramework.Controls.MetroButton();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarmetroButton = new MetroFramework.Controls.MetroButton();
            this.FiltrometroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.CriteriometroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechacheckBox);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.DesdemetroDateTime);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.HastametroDateTime);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 60);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // FechacheckBox
            // 
            this.FechacheckBox.AutoSize = true;
            this.FechacheckBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechacheckBox.Location = new System.Drawing.Point(0, 0);
            this.FechacheckBox.Name = "FechacheckBox";
            this.FechacheckBox.Size = new System.Drawing.Size(105, 18);
            this.FechacheckBox.TabIndex = 22;
            this.FechacheckBox.Text = "Filtrar Por Fecha";
            this.FechacheckBox.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Desde:";
            // 
            // DesdemetroDateTime
            // 
            this.DesdemetroDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdemetroDateTime.Location = new System.Drawing.Point(58, 19);
            this.DesdemetroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.DesdemetroDateTime.Name = "DesdemetroDateTime";
            this.DesdemetroDateTime.Size = new System.Drawing.Size(105, 29);
            this.DesdemetroDateTime.TabIndex = 15;
            this.DesdemetroDateTime.ValueChanged += new System.EventHandler(this.DesdemetroDateTime_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(169, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Hasta:";
            // 
            // HastametroDateTime
            // 
            this.HastametroDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastametroDateTime.Location = new System.Drawing.Point(219, 19);
            this.HastametroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.HastametroDateTime.Name = "HastametroDateTime";
            this.HastametroDateTime.Size = new System.Drawing.Size(101, 29);
            this.HastametroDateTime.TabIndex = 16;
            this.HastametroDateTime.ValueChanged += new System.EventHandler(this.HastametroDateTime_ValueChanged);
            // 
            // ImprimirmetroButton
            // 
            this.ImprimirmetroButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImprimirmetroButton.BackgroundImage")));
            this.ImprimirmetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImprimirmetroButton.Location = new System.Drawing.Point(806, 423);
            this.ImprimirmetroButton.Name = "ImprimirmetroButton";
            this.ImprimirmetroButton.Size = new System.Drawing.Size(105, 53);
            this.ImprimirmetroButton.TabIndex = 46;
            this.ImprimirmetroButton.UseSelectable = true;
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(23, 129);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(888, 288);
            this.ConsultadataGridView.TabIndex = 45;
            // 
            // BuscarmetroButton
            // 
            this.BuscarmetroButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarmetroButton.BackgroundImage")));
            this.BuscarmetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BuscarmetroButton.Location = new System.Drawing.Point(852, 87);
            this.BuscarmetroButton.Name = "BuscarmetroButton";
            this.BuscarmetroButton.Size = new System.Drawing.Size(59, 24);
            this.BuscarmetroButton.TabIndex = 44;
            this.BuscarmetroButton.UseSelectable = true;
            this.BuscarmetroButton.Click += new System.EventHandler(this.BuscarmetroButton_Click);
            // 
            // FiltrometroComboBox
            // 
            this.FiltrometroComboBox.FormattingEnabled = true;
            this.FiltrometroComboBox.ItemHeight = 23;
            this.FiltrometroComboBox.Items.AddRange(new object[] {
            "Todo",
            "ID"});
            this.FiltrometroComboBox.Location = new System.Drawing.Point(432, 82);
            this.FiltrometroComboBox.Name = "FiltrometroComboBox";
            this.FiltrometroComboBox.Size = new System.Drawing.Size(173, 29);
            this.FiltrometroComboBox.TabIndex = 43;
            this.FiltrometroComboBox.UseSelectable = true;
            this.FiltrometroComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrometroComboBox_SelectedIndexChanged);
            // 
            // CriteriometroTextBox
            // 
            // 
            // 
            // 
            this.CriteriometroTextBox.CustomButton.Image = null;
            this.CriteriometroTextBox.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.CriteriometroTextBox.CustomButton.Name = "";
            this.CriteriometroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CriteriometroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CriteriometroTextBox.CustomButton.TabIndex = 1;
            this.CriteriometroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CriteriometroTextBox.CustomButton.UseSelectable = true;
            this.CriteriometroTextBox.CustomButton.Visible = false;
            this.CriteriometroTextBox.Lines = new string[0];
            this.CriteriometroTextBox.Location = new System.Drawing.Point(673, 88);
            this.CriteriometroTextBox.MaxLength = 32767;
            this.CriteriometroTextBox.Name = "CriteriometroTextBox";
            this.CriteriometroTextBox.PasswordChar = '\0';
            this.CriteriometroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CriteriometroTextBox.SelectedText = "";
            this.CriteriometroTextBox.SelectionLength = 0;
            this.CriteriometroTextBox.SelectionStart = 0;
            this.CriteriometroTextBox.ShortcutsEnabled = true;
            this.CriteriometroTextBox.Size = new System.Drawing.Size(173, 23);
            this.CriteriometroTextBox.TabIndex = 42;
            this.CriteriometroTextBox.UseSelectable = true;
            this.CriteriometroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CriteriometroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CriteriometroTextBox.Click += new System.EventHandler(this.CriteriometroTextBox_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(611, 92);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 41;
            this.metroLabel4.Text = "Criterio:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(384, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 40;
            this.metroLabel3.Text = "Filtro:";
            // 
            // ConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImprimirmetroButton);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.BuscarmetroButton);
            this.Controls.Add(this.FiltrometroComboBox);
            this.Controls.Add(this.CriteriometroTextBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Name = "ConsultaVentas";
            this.Text = "CONSULTA DE VENTAS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox FechacheckBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime DesdemetroDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime HastametroDateTime;
        private MetroFramework.Controls.MetroButton ImprimirmetroButton;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private MetroFramework.Controls.MetroButton BuscarmetroButton;
        private MetroFramework.Controls.MetroComboBox FiltrometroComboBox;
        private MetroFramework.Controls.MetroTextBox CriteriometroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}