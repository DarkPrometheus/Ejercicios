namespace Ejercicios.DarkPrometheus.Parte1
{
    partial class HoraFutura
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHorafinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHoraASumar = new System.Windows.Forms.TextBox();
            this.txthoraInicial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHorafinal
            // 
            this.lblHorafinal.AutoSize = true;
            this.lblHorafinal.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.lblHorafinal.Location = new System.Drawing.Point(86, 183);
            this.lblHorafinal.Name = "lblHorafinal";
            this.lblHorafinal.Size = new System.Drawing.Size(139, 21);
            this.lblHorafinal.TabIndex = 6;
            this.lblHorafinal.Text = "La hora final es:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.label2.Location = new System.Drawing.Point(109, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Horas a sumar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hora inicial:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.button1.Location = new System.Drawing.Point(113, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHoraASumar
            // 
            this.txtHoraASumar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.txtHoraASumar.Location = new System.Drawing.Point(135, 151);
            this.txtHoraASumar.Name = "txtHoraASumar";
            this.txtHoraASumar.Size = new System.Drawing.Size(68, 29);
            this.txtHoraASumar.TabIndex = 3;
            // 
            // txthoraInicial
            // 
            this.txthoraInicial.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.txthoraInicial.Location = new System.Drawing.Point(135, 95);
            this.txthoraInicial.Name = "txthoraInicial";
            this.txthoraInicial.Size = new System.Drawing.Size(68, 29);
            this.txthoraInicial.TabIndex = 4;
            // 
            // HoraFutura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHorafinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHoraASumar);
            this.Controls.Add(this.txthoraInicial);
            this.Name = "HoraFutura";
            this.Size = new System.Drawing.Size(384, 351);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorafinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHoraASumar;
        private System.Windows.Forms.TextBox txthoraInicial;
    }
}
