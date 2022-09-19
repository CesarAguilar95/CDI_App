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
        SQL_Connection Conexion;

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

        private void button3_Click(object sender, EventArgs e)
        {
            string PLUBuscado = PLUText.Text;

            Conexion = new SQL_Connection();//Aqui el constructor de la conexion nueva
            Conexion.ConsultaSQL("SELECT Descripcion, Especie FROM T_CatalogoInicial WHERE ID_PLU = '" + PLUBuscado + "' ");//Aqui envia la consulta a la conexion nueva
            Console.WriteLine("SELECT Descripcion, Especie FROM T_CatalogoInicial WHERE ID_PLU = '" + PLUBuscado + "' ");

            foreach(DataRow DR in Conexion.ConsultaConSalida().Rows)//Aqui descarga la informacion de el return _DT de la misma conexion 
            {
                DescripcionText.Text = DR[0].ToString();
                EspecieText.Text = DR[1].ToString();
            }

        }
    }
}

