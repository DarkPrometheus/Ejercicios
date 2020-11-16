namespace Ejercicios.DarkPrometheus.Parte1
{
    partial class frmCirculos
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
            this.txtRadio = new System.Windows.Forms.NumericUpDown();
            this.lblTituloArea = new System.Windows.Forms.Label();
            this.lblTituloPerimetro = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultadoPerimetro = new System.Windows.Forms.Label();
            this.lblResultadoArea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtRadio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRadio
            // 
            this.txtRadio.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.txtRadio.Location = new System.Drawing.Point(254, 179);
            this.txtRadio.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(80, 29);
            this.txtRadio.TabIndex = 13;
            // 
            // lblTituloArea
            // 
            this.lblTituloArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloArea.AutoSize = true;
            this.lblTituloArea.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.lblTituloArea.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTituloArea.Location = new System.Drawing.Point(235, 253);
            this.lblTituloArea.Name = "lblTituloArea";
            this.lblTituloArea.Size = new System.Drawing.Size(49, 21);
            this.lblTituloArea.TabIndex = 11;
            this.lblTituloArea.Text = "Área:";
            // 
            // lblTituloPerimetro
            // 
            this.lblTituloPerimetro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloPerimetro.AutoSize = true;
            this.lblTituloPerimetro.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.lblTituloPerimetro.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTituloPerimetro.Location = new System.Drawing.Point(229, 211);
            this.lblTituloPerimetro.Name = "lblTituloPerimetro";
            this.lblTituloPerimetro.Size = new System.Drawing.Size(84, 21);
            this.lblTituloPerimetro.TabIndex = 10;
            this.lblTituloPerimetro.Text = "Perimetro:";
            // 
            // lblRadio
            // 
            this.lblRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRadio.AutoSize = true;
            this.lblRadio.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadio.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRadio.Location = new System.Drawing.Point(250, 155);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(58, 21);
            this.lblRadio.TabIndex = 9;
            this.lblRadio.Text = "Radio:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(232, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblResultadoPerimetro
            // 
            this.lblResultadoPerimetro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultadoPerimetro.AutoSize = true;
            this.lblResultadoPerimetro.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.lblResultadoPerimetro.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblResultadoPerimetro.Location = new System.Drawing.Point(271, 232);
            this.lblResultadoPerimetro.Name = "lblResultadoPerimetro";
            this.lblResultadoPerimetro.Size = new System.Drawing.Size(25, 21);
            this.lblResultadoPerimetro.TabIndex = 11;
            this.lblResultadoPerimetro.Text = "...";
            // 
            // lblResultadoArea
            // 
            this.lblResultadoArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultadoArea.AutoSize = true;
            this.lblResultadoArea.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.lblResultadoArea.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblResultadoArea.Location = new System.Drawing.Point(271, 274);
            this.lblResultadoArea.Name = "lblResultadoArea";
            this.lblResultadoArea.Size = new System.Drawing.Size(25, 21);
            this.lblResultadoArea.TabIndex = 11;
            this.lblResultadoArea.Text = "...";
            // 
            // frmCirculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblResultadoArea);
            this.Controls.Add(this.lblResultadoPerimetro);
            this.Controls.Add(this.lblTituloArea);
            this.Controls.Add(this.lblTituloPerimetro);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.button1);
            this.Name = "frmCirculos";
            this.Size = new System.Drawing.Size(598, 483);
            ((System.ComponentModel.ISupportInitialize)(this.txtRadio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown txtRadio;
        private System.Windows.Forms.Label lblTituloArea;
        private System.Windows.Forms.Label lblTituloPerimetro;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultadoPerimetro;
        private System.Windows.Forms.Label lblResultadoArea;
    }
}
