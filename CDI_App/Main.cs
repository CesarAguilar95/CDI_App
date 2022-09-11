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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //float flotante;
            //int entero;
            //bool booleana;
            //double doble;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string User, Pass;

            User = "Admin";
            Pass = "1234";

            if (UsuarioTexto.Text == "") //comparacion de usuario que no es igual a ""
            {
                MessageBox.Show("No se ha insertado un usuario");
            }
            else 
            {
                if(ContraseñaTexto.Text == "") //comparacion de contraseña no esta vacia
                {
                    MessageBox.Show("No se ha insertado una contraseña");
                }
                else
                {
                    if(User == UsuarioTexto.Text)//comparacion de si existe el usuario
                    {
                        if(Pass == ContraseñaTexto.Text)//comparacion de contraseña

                        {
                            MessageBox.Show("Bienvenido al sistema CDI");
                        }
                        else //aqui nos dice si esta mal la contraseña
                        {
                            ContraseñaTexto.Text = "";
                            MessageBox.Show("Contraseña incorrecta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe");
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         if(checkBox1.Checked == true)
            {
                ContraseñaTexto.PasswordChar = '\0';
            }
            else
            {
                ContraseñaTexto.PasswordChar = '*';
            }
        }
    }
}
