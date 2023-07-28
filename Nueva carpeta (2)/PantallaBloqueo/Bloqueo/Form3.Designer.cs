namespace Bloqueo
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIncidencia = new System.Windows.Forms.ComboBox();
            this.btnEnviarBitacora = new System.Windows.Forms.Button();
            this.lblnameAlumno = new System.Windows.Forms.Label();
            this.lblnameClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LLenado de bitacora";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Favor de registrar alnuna incidencia que se haya sucitado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alumno: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clase: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Incidencia";
            // 
            // cmbIncidencia
            // 
            this.cmbIncidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIncidencia.FormattingEnabled = true;
            this.cmbIncidencia.Items.AddRange(new object[] {
            "No sirve el raton",
            "No prende el monitor",
            "No prende la PC",
            "Esta lenta la PC"});
            this.cmbIncidencia.Location = new System.Drawing.Point(205, 200);
            this.cmbIncidencia.Name = "cmbIncidencia";
            this.cmbIncidencia.Size = new System.Drawing.Size(121, 24);
            this.cmbIncidencia.TabIndex = 5;
            // 
            // btnEnviarBitacora
            // 
            this.btnEnviarBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarBitacora.Location = new System.Drawing.Point(160, 258);
            this.btnEnviarBitacora.Name = "btnEnviarBitacora";
            this.btnEnviarBitacora.Size = new System.Drawing.Size(75, 27);
            this.btnEnviarBitacora.TabIndex = 6;
            this.btnEnviarBitacora.Text = "Enviar";
            this.btnEnviarBitacora.UseVisualStyleBackColor = true;
            this.btnEnviarBitacora.Click += new System.EventHandler(this.btnEnviarBitacora_Click);
            // 
            // lblnameAlumno
            // 
            this.lblnameAlumno.AutoSize = true;
            this.lblnameAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameAlumno.Location = new System.Drawing.Point(154, 114);
            this.lblnameAlumno.Name = "lblnameAlumno";
            this.lblnameAlumno.Size = new System.Drawing.Size(194, 17);
            this.lblnameAlumno.TabIndex = 7;
            this.lblnameAlumno.Text = "aquí va el nombre del alumno";
            // 
            // lblnameClass
            // 
            this.lblnameClass.AutoSize = true;
            this.lblnameClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameClass.Location = new System.Drawing.Point(157, 154);
            this.lblnameClass.Name = "lblnameClass";
            this.lblnameClass.Size = new System.Drawing.Size(193, 17);
            this.lblnameClass.TabIndex = 8;
            this.lblnameClass.Text = "aquí va el nombre de la clase";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 309);
            this.Controls.Add(this.lblnameClass);
            this.Controls.Add(this.lblnameAlumno);
            this.Controls.Add(this.btnEnviarBitacora);
            this.Controls.Add(this.cmbIncidencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIncidencia;
        private System.Windows.Forms.Button btnEnviarBitacora;
        private System.Windows.Forms.Label lblnameAlumno;
        private System.Windows.Forms.Label lblnameClass;
    }
}