
namespace CDI_App
{
    partial class VentanaEtiquetado
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
            this.TextMan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Automatico = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Manual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TextAut = new System.Windows.Forms.Label();
            this.DescripcionText = new System.Windows.Forms.Label();
            this.PLUText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.EspecieText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextMan
            // 
            this.TextMan.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMan.Location = new System.Drawing.Point(99, 188);
            this.TextMan.Name = "TextMan";
            this.TextMan.Size = new System.Drawing.Size(245, 63);
            this.TextMan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kg";
            // 
            // Automatico
            // 
            this.Automatico.AutoSize = true;
            this.Automatico.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Automatico.ForeColor = System.Drawing.Color.White;
            this.Automatico.Location = new System.Drawing.Point(468, 102);
            this.Automatico.Name = "Automatico";
            this.Automatico.Size = new System.Drawing.Size(132, 28);
            this.Automatico.TabIndex = 6;
            this.Automatico.TabStop = true;
            this.Automatico.Text = "Automatico";
            this.Automatico.UseVisualStyleBackColor = true;
            this.Automatico.CheckedChanged += new System.EventHandler(this.Automatico_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Peso";
            // 
            // Manual
            // 
            this.Manual.AutoSize = true;
            this.Manual.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manual.ForeColor = System.Drawing.Color.White;
            this.Manual.Location = new System.Drawing.Point(99, 154);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(95, 28);
            this.Manual.TabIndex = 5;
            this.Manual.TabStop = true;
            this.Manual.Text = "Manual";
            this.Manual.UseVisualStyleBackColor = true;
            this.Manual.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(803, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 55);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kg";
            // 
            // TextAut
            // 
            this.TextAut.BackColor = System.Drawing.Color.White;
            this.TextAut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextAut.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAut.ForeColor = System.Drawing.Color.Black;
            this.TextAut.Location = new System.Drawing.Point(468, 133);
            this.TextAut.Name = "TextAut";
            this.TextAut.Size = new System.Drawing.Size(329, 118);
            this.TextAut.TabIndex = 8;
            this.TextAut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescripcionText
            // 
            this.DescripcionText.BackColor = System.Drawing.Color.White;
            this.DescripcionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescripcionText.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionText.ForeColor = System.Drawing.Color.Black;
            this.DescripcionText.Location = new System.Drawing.Point(468, 415);
            this.DescripcionText.Name = "DescripcionText";
            this.DescripcionText.Size = new System.Drawing.Size(527, 120);
            this.DescripcionText.TabIndex = 9;
            this.DescripcionText.Text = "Producto";
            this.DescripcionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PLUText
            // 
            this.PLUText.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLUText.Location = new System.Drawing.Point(468, 328);
            this.PLUText.Name = "PLUText";
            this.PLUText.Size = new System.Drawing.Size(527, 44);
            this.PLUText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(465, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "PLU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(465, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripcion de producto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1015, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 92);
            this.button2.TabIndex = 13;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1015, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 44);
            this.button3.TabIndex = 14;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EspecieText
            // 
            this.EspecieText.BackColor = System.Drawing.Color.White;
            this.EspecieText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EspecieText.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EspecieText.ForeColor = System.Drawing.Color.Black;
            this.EspecieText.Location = new System.Drawing.Point(99, 415);
            this.EspecieText.Name = "EspecieText";
            this.EspecieText.Size = new System.Drawing.Size(245, 120);
            this.EspecieText.TabIndex = 15;
            this.EspecieText.Text = "Producto";
            this.EspecieText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(96, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Especie";
            // 
            // VentanaEtiquetado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(9)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1284, 551);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EspecieText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PLUText);
            this.Controls.Add(this.DescripcionText);
            this.Controls.Add(this.TextAut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Automatico);
            this.Controls.Add(this.Manual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextMan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaEtiquetado";
            this.Text = "Etiquetado";
            this.Load += new System.EventHandler(this.VentanaEtiquetado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextMan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Automatico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Manual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TextAut;
        private System.Windows.Forms.Label DescripcionText;
        private System.Windows.Forms.TextBox PLUText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label EspecieText;
        private System.Windows.Forms.Label label7;
    }
}