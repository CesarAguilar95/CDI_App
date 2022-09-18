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
    public partial class VentanaEtiquetado : Form
    {
        public VentanaEtiquetado()
        {
            InitializeComponent();
        }


        private void VentanaEtiquetado_Load(object sender, EventArgs e)
        {
            this.Automatico.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(Manual.Checked == true)
            {
                TextMan.Enabled = true;

                this.TextAut.Text = "Manual";
            }
        }

        private void Automatico_CheckedChanged(object sender, EventArgs e)
        {
            if(Automatico.Checked == true)
            {
                this.TextAut.Text = ""; // aqui va atener el dato de donde se lee
                TextMan.Text = "";
                TextMan.Enabled = false;
            }
        }
    }
}

