namespace ProyectoFinal
{
    partial class frmLenguaje
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbLenguaje = new System.Windows.Forms.ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lenguaje";
            // 
            // cbLenguaje
            // 
            this.cbLenguaje.FormattingEnabled = true;
            this.cbLenguaje.Items.AddRange(new object[] {
            "Java",
            "Basic",
            "Clipper",
            "Cobol",
            "Dbase",
            "Fortran",
            "Pascal",
            "FoxPro",
            "Python",
            "Vb"});
            this.cbLenguaje.Location = new System.Drawing.Point(102, 33);
            this.cbLenguaje.Name = "cbLenguaje";
            this.cbLenguaje.Size = new System.Drawing.Size(121, 21);
            this.cbLenguaje.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(148, 82);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmLenguaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 129);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.cbLenguaje);
            this.Controls.Add(this.label1);
            this.Name = "frmLenguaje";
            this.Text = "frmLenguaje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLenguaje_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLenguaje;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}