using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace CDI_App
{
    class SQL_Connection
    {
        private static string ConnectionString = @"Server=tcp:agsisc-server.database.windows.net,1433;Initial Catalog=DB_CDI_APP;Persist Security Info=False;User ID=AACI951;Password=Cesar8ta;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //Cadena de conexion de la base de datos en Azure SQL 


        private SqlConnection _Conexion;
        public SqlCommand Comando;
        private SqlDataAdapter _Da;
        private DataTable _Dt;


        public SQL_Connection()//Crea la conexion  utilizando el connection string de arriba
        {
            _Conexion = new SqlConnection(ConnectionString);
            _Conexion.Open();
        }

        public void ConsultaSQL (string Consultatexto)//aqui genera el comnado utilizando la consulta enviada por el usuario que llama el metodo y la ahce a la conexion de arriba
        {
            Comando = new SqlCommand(Consultatexto, _Conexion);
        }

        public DataTable ConsultaConSalida()//Aqui crea el adaptador para llenar una tabla nueva y retorna esa tabla
        {
            _Da = new SqlDataAdapter(Comando);//nuevo adaptador usando el comando dee arriba
            _Dt = new DataTable();//nueva tabla en memoria
            _Da.Fill(_Dt);//llena la tabal creada con la info en el adaptador

            _Conexion.Close();//cierra conexion
            return _Dt;//devuleve a donde fue llamada el metodo al usuario la info en forma de tabla
        }

        public void ConsultaSinSalida()//Aqui se realiza la consulta sin salida de datos es utilizada para UPDATE o INSERTS
        {
            Comando.ExecuteNonQuery();
            _Conexion.Close();
        }
    }
}
