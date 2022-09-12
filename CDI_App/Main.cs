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
                            VerificacionUsuario(UsuarioTexto.Text);
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

        private void VerificacionUsuario(string UsuarioEnviado) //Funcion que nos va a verificar el tipo de accesos del usuario
        {
            //Aqui se obtiene el usuario
            string Usuario = UsuarioEnviado;
            string TipoPermiso;
            //Usuario 1, Admin = permiso para todo
            //Usuario 2, SingleUser = Permiso solo etiquetado y consulta
            //Usuario 3, ConsultUser = permiso para consulta


            TipoPermiso = "SingleUser";//Esta variable se va a llenar desde la base de datos en la consulta

            ControlForm AbrirForm = new ControlForm();


            if(TipoPermiso == "Admin")//este permiso se lee de la base de datos
            {
                VariablesGlobales.Permisos = "Admin";
            }

            if (TipoPermiso == "SingleUser")//este permiso se lee de la base de datos
            {
                VariablesGlobales.Permisos = "SingleUser";
            }

            if (TipoPermiso == "ConsultUser")//este permiso se lee de la base de datos
            {
                VariablesGlobales.Permisos = "ConsultUser";
            }

            this.Hide();
            AbrirForm.ShowDialog();
            this.Show();

            UsuarioTexto.Text = "";
            ContraseñaTexto.Text = "";
            checkBox1.Checked = false;

        }
    }
}
