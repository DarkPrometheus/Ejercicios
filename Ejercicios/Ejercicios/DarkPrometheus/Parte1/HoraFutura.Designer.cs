namespace Ejercicios.DarkPrometheus.Parte1
{
    partial class frmHoraFutura
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
            this.lblHorasSumar = new System.Windows.Forms.Label();
            this.lblHoraInicial = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txthoraInicial = new System.Windows.Forms.NumericUpDown();
            this.txtHoraASumar = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txthoraInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraASumar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHorafinal
            // 
            this.lblHorafinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorafinal.AutoSize = true;
            this.lblHorafinal.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.lblHorafinal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHorafinal.Location = new System.Drawing.Point(231, 232);
            this.lblHorafinal.Name = "lblHorafinal";
            this.lblHorafinal.Size = new System.Drawing.Size(116, 21);
            this.lblHorafinal.TabIndex = 6;
            this.lblHorafinal.Text = "A la espera...";
            // 
            // lblHorasSumar
            // 
            this.lblHorasSumar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorasSumar.AutoSize = true;
            this.lblHorasSumar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.lblHorasSumar.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHorasSumar.Location = new System.Drawing.Point(224, 176);
            this.lblHorasSumar.Name = "lblHorasSumar";
            this.lblHorasSumar.Size = new System.Drawing.Size(129, 21);
            this.lblHorasSumar.TabIndex = 5;
            this.lblHorasSumar.Text = "Horas a sumar:";
            // 
            // lblHoraInicial
            // 
            this.lblHoraInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoraInicial.AutoSize = true;
            this.lblHoraInicial.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicial.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHoraInicial.Location = new System.Drawing.Point(239, 120);
            this.lblHoraInicial.Name = "lblHoraInicial";
            this.lblHoraInicial.Size = new System.Drawing.Size(101, 21);
            this.lblHoraInicial.TabIndex = 4;
            this.lblHoraInicial.Text = "Hora inicial:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(228, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txthoraInicial
            // 
            this.txthoraInicial.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.txthoraInicial.Location = new System.Drawing.Point(243, 144);
            this.txthoraInicial.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txthoraInicial.Name = "txthoraInicial";
            this.txthoraInicial.Size = new System.Drawing.Size(80, 29);
            this.txthoraInicial.TabIndex = 7;
            // 
            // txtHoraASumar
            // 
            this.txtHoraASumar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.txtHoraASumar.Location = new System.Drawing.Point(243, 200);
            this.txtHoraASumar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtHoraASumar.Name = "txtHoraASumar";
            this.txtHoraASumar.Size = new System.Drawing.Size(80, 29);
            this.txtHoraASumar.TabIndex = 7;
            // 
            // frmHoraFutura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.txtHoraASumar);
            this.Controls.Add(this.txthoraInicial);
            this.Controls.Add(this.lblHorafinal);
            this.Controls.Add(this.lblHorasSumar);
            this.Controls.Add(this.lblHoraInicial);
            this.Controls.Add(this.button1);
            this.Name = "frmHoraFutura";
            this.Size = new System.Drawing.Size(598, 483);
            this.Resize += new System.EventHandler(this.HoraFutura_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.txthoraInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraASumar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorafinal;
        private System.Windows.Forms.Label lblHorasSumar;
        private System.Windows.Forms.Label lblHoraInicial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txthoraInicial;
        private System.Windows.Forms.NumericUpDown txtHoraASumar;
    }
}
