namespace WindowsFormsApplication1
{
    partial class frnOperaciones
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbGrupoA = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtValB = new System.Windows.Forms.TextBox();
            this.txtValA = new System.Windows.Forms.TextBox();
            this.lblValB = new System.Windows.Forms.Label();
            this.lblValA = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.grbGrupoA.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGrupoA
            // 
            this.grbGrupoA.Controls.Add(this.lblResultado);
            this.grbGrupoA.Controls.Add(this.txtValB);
            this.grbGrupoA.Controls.Add(this.txtValA);
            this.grbGrupoA.Controls.Add(this.lblValB);
            this.grbGrupoA.Controls.Add(this.lblValA);
            this.grbGrupoA.Location = new System.Drawing.Point(12, 28);
            this.grbGrupoA.Name = "grbGrupoA";
            this.grbGrupoA.Size = new System.Drawing.Size(425, 184);
            this.grbGrupoA.TabIndex = 0;
            this.grbGrupoA.TabStop = false;
            this.grbGrupoA.Text = "groupBox1";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(116, 138);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(117, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "RESULTADO";
            // 
            // txtValB
            // 
            this.txtValB.Location = new System.Drawing.Point(88, 60);
            this.txtValB.Name = "txtValB";
            this.txtValB.Size = new System.Drawing.Size(100, 20);
            this.txtValB.TabIndex = 4;
            // 
            // txtValA
            // 
            this.txtValA.Location = new System.Drawing.Point(88, 17);
            this.txtValA.Name = "txtValA";
            this.txtValA.Size = new System.Drawing.Size(100, 20);
            this.txtValA.TabIndex = 6;
            // 
            // lblValB
            // 
            this.lblValB.AutoSize = true;
            this.lblValB.Location = new System.Drawing.Point(29, 60);
            this.lblValB.Name = "lblValB";
            this.lblValB.Size = new System.Drawing.Size(53, 13);
            this.lblValB.TabIndex = 1;
            this.lblValB.Text = "VALOR B";
            // 
            // lblValA
            // 
            this.lblValA.AutoSize = true;
            this.lblValA.Location = new System.Drawing.Point(29, 20);
            this.lblValA.Name = "lblValA";
            this.lblValA.Size = new System.Drawing.Size(53, 13);
            this.lblValA.TabIndex = 0;
            this.lblValA.Text = "VALOR A";
            this.lblValA.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(284, 37);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(111, 23);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "&SUMA";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click_1);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(284, 66);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(111, 23);
            this.btnResta.TabIndex = 2;
            this.btnResta.Text = "&RESTA";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(284, 95);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(111, 23);
            this.btnMultiplicacion.TabIndex = 3;
            this.btnMultiplicacion.Text = "&MULTIPLICACION";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(284, 124);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(111, 23);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "&DIVISION";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // frnOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 243);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.grbGrupoA);
            this.Name = "frnOperaciones";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frnOperaciones_Load);
            this.grbGrupoA.ResumeLayout(false);
            this.grbGrupoA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGrupoA;
        private System.Windows.Forms.TextBox txtValB;
        private System.Windows.Forms.TextBox txtValA;
        private System.Windows.Forms.Label lblValB;
        private System.Windows.Forms.Label lblValA;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
    }
}

