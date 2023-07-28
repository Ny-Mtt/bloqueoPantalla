namespace Bloqueo
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblnameAlumno = new System.Windows.Forms.Label();
            this.cmbIncd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tmrSend = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Llenado de la bitacora de incidencias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alumno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materia: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Observaciones";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(182, 306);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 29);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblnameAlumno
            // 
            this.lblnameAlumno.AutoSize = true;
            this.lblnameAlumno.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameAlumno.Location = new System.Drawing.Point(168, 127);
            this.lblnameAlumno.Name = "lblnameAlumno";
            this.lblnameAlumno.Size = new System.Drawing.Size(214, 17);
            this.lblnameAlumno.TabIndex = 6;
            this.lblnameAlumno.Text = "aqui va el nombre del alumno";
            // 
            // cmbIncd
            // 
            this.cmbIncd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIncd.FormattingEnabled = true;
            this.cmbIncd.Location = new System.Drawing.Point(261, 238);
            this.cmbIncd.Name = "cmbIncd";
            this.cmbIncd.Size = new System.Drawing.Size(121, 24);
            this.cmbIncd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Favor de seleccionar la incidencia encontrada";
            // 
            // tmrSend
            // 
            this.tmrSend.Interval = 60000;
            this.tmrSend.Tick += new System.EventHandler(this.tmrSend_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 394);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIncd);
            this.Controls.Add(this.lblnameAlumno);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblnameAlumno;
        private System.Windows.Forms.ComboBox cmbIncd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrSend;
    }
}