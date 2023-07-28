namespace Bloqueo
{
    partial class Form2
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
            this.lblClase = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrMedio = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la clase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alumno";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClase.ForeColor = System.Drawing.Color.White;
            this.lblClase.Location = new System.Drawing.Point(43, 59);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(0, 17);
            this.lblClase.TabIndex = 1;
            this.lblClase.Click += new System.EventHandler(this.lblClase_Click);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.ForeColor = System.Drawing.Color.White;
            this.lblAlumno.Location = new System.Drawing.Point(43, 166);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(0, 17);
            this.lblAlumno.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrMedio
            // 
            this.tmrMedio.Interval = 60000;
            this.tmrMedio.Tick += new System.EventHandler(this.tmrMedio_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(146, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "m";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrMedio;
    }
}