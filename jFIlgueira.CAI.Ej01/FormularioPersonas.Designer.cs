namespace jFIlgueira.CAI.Ej01
{
    partial class FormularioPersona
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DocuementoTxt = new System.Windows.Forms.TextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.FechaNacimientoTxt = new System.Windows.Forms.TextBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // DocuementoTxt
            // 
            this.DocuementoTxt.Location = new System.Drawing.Point(245, 49);
            this.DocuementoTxt.Name = "DocuementoTxt";
            this.DocuementoTxt.Size = new System.Drawing.Size(138, 23);
            this.DocuementoTxt.TabIndex = 4;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(245, 101);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(138, 23);
            this.NombreTxt.TabIndex = 5;
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Location = new System.Drawing.Point(245, 153);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(138, 23);
            this.ApellidoTxt.TabIndex = 6;
            // 
            // FechaNacimientoTxt
            // 
            this.FechaNacimientoTxt.Location = new System.Drawing.Point(245, 212);
            this.FechaNacimientoTxt.Name = "FechaNacimientoTxt";
            this.FechaNacimientoTxt.Size = new System.Drawing.Size(138, 23);
            this.FechaNacimientoTxt.TabIndex = 7;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AceptarBtn.Location = new System.Drawing.Point(152, 282);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(105, 37);
            this.AceptarBtn.TabIndex = 8;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelarBtn.Location = new System.Drawing.Point(277, 282);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(106, 37);
            this.CancelarBtn.TabIndex = 9;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // FormularioPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 340);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.FechaNacimientoTxt);
            this.Controls.Add(this.ApellidoTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.DocuementoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormularioPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Ingreso de Personas";
            this.Load += new System.EventHandler(this.FormularioPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox DocuementoTxt;
        private TextBox NombreTxt;
        private TextBox ApellidoTxt;
        private TextBox FechaNacimientoTxt;
        private Button AceptarBtn;
        private Button CancelarBtn;
    }
}