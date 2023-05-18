namespace ProyectoFinal
{
    partial class frmRegistro
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
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnXlsx = new System.Windows.Forms.Button();
            this.sfdExportar = new System.Windows.Forms.SaveFileDialog();
            this.cbUsuario = new System.Windows.Forms.CheckBox();
            this.cbLenguaje = new System.Windows.Forms.CheckBox();
            this.cbFecha = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbLenguaje = new System.Windows.Forms.TextBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(12, 67);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(500, 294);
            this.dgvRegistros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exportar";
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(114, 27);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(75, 23);
            this.btnTxt.TabIndex = 2;
            this.btnTxt.Text = "TXT";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(218, 27);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(75, 23);
            this.btnCsv.TabIndex = 3;
            this.btnCsv.Text = "CSV";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnXlsx
            // 
            this.btnXlsx.Location = new System.Drawing.Point(330, 27);
            this.btnXlsx.Name = "btnXlsx";
            this.btnXlsx.Size = new System.Drawing.Size(75, 23);
            this.btnXlsx.TabIndex = 4;
            this.btnXlsx.Text = "XLSX";
            this.btnXlsx.UseVisualStyleBackColor = true;
            this.btnXlsx.Click += new System.EventHandler(this.btnXlsx_Click);
            // 
            // cbUsuario
            // 
            this.cbUsuario.AutoSize = true;
            this.cbUsuario.Location = new System.Drawing.Point(542, 129);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(62, 17);
            this.cbUsuario.TabIndex = 5;
            this.cbUsuario.Text = "Usuario";
            this.cbUsuario.UseVisualStyleBackColor = true;
            // 
            // cbLenguaje
            // 
            this.cbLenguaje.AutoSize = true;
            this.cbLenguaje.Location = new System.Drawing.Point(542, 165);
            this.cbLenguaje.Name = "cbLenguaje";
            this.cbLenguaje.Size = new System.Drawing.Size(70, 17);
            this.cbLenguaje.TabIndex = 6;
            this.cbLenguaje.Text = "Lenguaje";
            this.cbLenguaje.UseVisualStyleBackColor = true;
            // 
            // cbFecha
            // 
            this.cbFecha.AutoSize = true;
            this.cbFecha.Location = new System.Drawing.Point(542, 206);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(56, 17);
            this.cbFecha.TabIndex = 7;
            this.cbFecha.Text = "Fecha";
            this.cbFecha.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filtrar";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(621, 129);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 9;
            // 
            // tbLenguaje
            // 
            this.tbLenguaje.Location = new System.Drawing.Point(621, 165);
            this.tbLenguaje.Name = "tbLenguaje";
            this.tbLenguaje.Size = new System.Drawing.Size(100, 20);
            this.tbLenguaje.TabIndex = 10;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(621, 206);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpInicio.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(660, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "a";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(621, 250);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(100, 20);
            this.dtpFinal.TabIndex = 13;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(646, 298);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 14;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 373);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.tbLenguaje);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFecha);
            this.Controls.Add(this.cbLenguaje);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.btnXlsx);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegistros);
            this.Name = "frmRegistro";
            this.Text = "frmRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnXlsx;
        private System.Windows.Forms.SaveFileDialog sfdExportar;
        private System.Windows.Forms.CheckBox cbUsuario;
        private System.Windows.Forms.CheckBox cbLenguaje;
        private System.Windows.Forms.CheckBox cbFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbLenguaje;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Button btnFiltrar;
    }
}