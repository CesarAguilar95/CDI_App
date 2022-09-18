
namespace CDI_App
{
    partial class ControlForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Etiquetado = new System.Windows.Forms.Button();
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Etiquetado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 87);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("RomanD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(518, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 87);
            this.button3.TabIndex = 2;
            this.button3.Text = "Diseño etiqueta";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("RomanD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(259, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 87);
            this.button2.TabIndex = 1;
            this.button2.Text = "Inventario / catalogo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Etiquetado
            // 
            this.Etiquetado.BackColor = System.Drawing.SystemColors.Highlight;
            this.Etiquetado.Dock = System.Windows.Forms.DockStyle.Left;
            this.Etiquetado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Etiquetado.Font = new System.Drawing.Font("RomanD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiquetado.ForeColor = System.Drawing.Color.White;
            this.Etiquetado.Location = new System.Drawing.Point(0, 0);
            this.Etiquetado.Name = "Etiquetado";
            this.Etiquetado.Size = new System.Drawing.Size(259, 87);
            this.Etiquetado.TabIndex = 0;
            this.Etiquetado.Text = "Etiquetado";
            this.Etiquetado.UseVisualStyleBackColor = false;
            this.Etiquetado.Click += new System.EventHandler(this.Etiquetado_Click);
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.Location = new System.Drawing.Point(0, 181);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(1284, 551);
            this.PanelOpciones.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("RomanD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(777, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 87);
            this.button1.TabIndex = 4;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 729);
            this.Controls.Add(this.PanelOpciones);
            this.Controls.Add(this.panel1);
            this.Name = "ControlForm";
            this.Text = "Control";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Etiquetado;
        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.Button button1;
    }
}