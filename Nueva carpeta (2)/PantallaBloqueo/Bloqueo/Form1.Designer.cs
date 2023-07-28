namespace Bloqueo
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBloqueo = new System.Windows.Forms.Button();
            this.txtBoxNumClas = new System.Windows.Forms.TextBox();
            this.txtBoxMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 427);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(652, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "bienvenido para utilizar el equipo llene la información ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnBloqueo);
            this.panel2.Controls.Add(this.txtBoxNumClas);
            this.panel2.Controls.Add(this.txtBoxMatricula);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(170, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 314);
            this.panel2.TabIndex = 0;
            // 
            // btnBloqueo
            // 
            this.btnBloqueo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloqueo.Location = new System.Drawing.Point(181, 236);
            this.btnBloqueo.Name = "btnBloqueo";
            this.btnBloqueo.Size = new System.Drawing.Size(121, 37);
            this.btnBloqueo.TabIndex = 3;
            this.btnBloqueo.Text = "Desbloquear";
            this.btnBloqueo.UseVisualStyleBackColor = true;
            this.btnBloqueo.Click += new System.EventHandler(this.btnBloqueo_Click);
            // 
            // txtBoxNumClas
            // 
            this.txtBoxNumClas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumClas.Location = new System.Drawing.Point(190, 173);
            this.txtBoxNumClas.Name = "txtBoxNumClas";
            this.txtBoxNumClas.Size = new System.Drawing.Size(100, 24);
            this.txtBoxNumClas.TabIndex = 2;
            // 
            // txtBoxMatricula
            // 
            this.txtBoxMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMatricula.Location = new System.Drawing.Point(190, 74);
            this.txtBoxMatricula.Name = "txtBoxMatricula";
            this.txtBoxMatricula.Size = new System.Drawing.Size(100, 24);
            this.txtBoxMatricula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de clase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 446);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxNumClas;
        private System.Windows.Forms.TextBox txtBoxMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBloqueo;
        private System.Windows.Forms.Label label3;
    }
}

