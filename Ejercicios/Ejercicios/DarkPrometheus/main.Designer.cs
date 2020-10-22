namespace Ejercicios.DarkPrometheus
{
    partial class main
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
            this.btnParte1 = new System.Windows.Forms.Button();
            this.btnParte2 = new System.Windows.Forms.Button();
            this.btnParte3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ejercicios de programacion";
            // 
            // btnParte1
            // 
            this.btnParte1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParte1.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParte1.Location = new System.Drawing.Point(41, 99);
            this.btnParte1.Name = "btnParte1";
            this.btnParte1.Size = new System.Drawing.Size(268, 43);
            this.btnParte1.TabIndex = 3;
            this.btnParte1.Text = "Parte 1";
            this.btnParte1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParte1.UseVisualStyleBackColor = true;
            this.btnParte1.Click += new System.EventHandler(this.btnParte1_Click);
            // 
            // btnParte2
            // 
            this.btnParte2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParte2.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParte2.Location = new System.Drawing.Point(41, 148);
            this.btnParte2.Name = "btnParte2";
            this.btnParte2.Size = new System.Drawing.Size(268, 43);
            this.btnParte2.TabIndex = 3;
            this.btnParte2.Text = "Parte 2";
            this.btnParte2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParte2.UseVisualStyleBackColor = true;
            // 
            // btnParte3
            // 
            this.btnParte3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParte3.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParte3.Location = new System.Drawing.Point(41, 197);
            this.btnParte3.Name = "btnParte3";
            this.btnParte3.Size = new System.Drawing.Size(268, 43);
            this.btnParte3.TabIndex = 3;
            this.btnParte3.Text = "Parte 3";
            this.btnParte3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParte3.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 277);
            this.Controls.Add(this.btnParte3);
            this.Controls.Add(this.btnParte2);
            this.Controls.Add(this.btnParte1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParte1;
        private System.Windows.Forms.Button btnParte2;
        private System.Windows.Forms.Button btnParte3;
    }
}