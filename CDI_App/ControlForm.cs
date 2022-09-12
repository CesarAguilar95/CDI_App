using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDI_App
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        private void Etiquetado_Click(object sender, EventArgs e)
        {
            VentanaEtiquetado Abrir = new VentanaEtiquetado();

            Abrir.TopLevel = false;
            PanelOpciones.Controls.Add(Abrir);
            Abrir.Show();

        }
    }
}
