using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;



namespace Sistema_Personas
{
    class Class1
    {

        public static DataSet ejecuta(string cmd)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=minisistema");
            connection.Open();
            MySqlDataAdapter mySqlData = new MySqlDataAdapter(cmd,connection);
            DataSet dataset = new DataSet();

            mySqlData.Fill(dataset);
            connection.Close();
            return dataset;
        }









        /*
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-P9VH1GC; Initial Catalog=Personas; Integrated Security = true");
        private DataSet ds;

        //MOSTRAR DATOS
        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from personas", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }



        //BUSCAR UN NOMBRE
        public DataTable Buscar(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from personas where Nombre like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }



        //INSERTAR
        public bool Insertar(string id, string nombre, string apellido, string sexo, string telefono, string edad)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into personas values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}')", new string[] { id,nombre, apellido, sexo, telefono,edad }),conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }



        //ELIMINAR
        public bool Eliminar(string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from personas where id = '{0}'", id), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }



        //ACTUALIZAR
        public bool Actualizar(string id, string nombre, string apellido, string sexo, string telefono, string edad)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update personas set nombre = '{0}', apellido = '{1}', sexo = '{2}', telefono = '{3}', edad = '{4}' where id = {5} ", new string[] { nombre, apellido, sexo, telefono, edad, id }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
    

    */



    }
}
