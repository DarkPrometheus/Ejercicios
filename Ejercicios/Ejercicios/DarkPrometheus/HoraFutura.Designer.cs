namespace Ejercicios.DarkPrometheus
{
    partial class HoraFutura
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
            this.txthoraInicial = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoraASumar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHorafinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txthoraInicial
            // 
            this.txthoraInicial.Location = new System.Drawing.Point(15, 25);
            this.txthoraInicial.Name = "txthoraInicial";
            this.txthoraInicial.Size = new System.Drawing.Size(100, 20);
            this.txthoraInicial.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lanzar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora inicial:";
            // 
            // txtHoraASumar
            // 
            this.txtHoraASumar.Location = new System.Drawing.Point(15, 64);
            this.txtHoraASumar.Name = "txtHoraASumar";
            this.txtHoraASumar.Size = new System.Drawing.Size(100, 20);
            this.txtHoraASumar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horas a sumar:";
            // 
            // lblHorafinal
            // 
            this.lblHorafinal.AutoSize = true;
            this.lblHorafinal.Location = new System.Drawing.Point(38, 87);
            this.lblHorafinal.Name = "lblHorafinal";
            this.lblHorafinal.Size = new System.Drawing.Size(52, 13);
            this.lblHorafinal.TabIndex = 2;
            this.lblHorafinal.Text = "HoraFinal";
            // 
            // HoraFutura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 141);
            this.Controls.Add(this.lblHorafinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHoraASumar);
            this.Controls.Add(this.txthoraInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HoraFutura";
            this.Text = "HoraFutura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthoraInicial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoraASumar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHorafinal;
    }
}