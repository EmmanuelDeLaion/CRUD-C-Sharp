using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace Sistema_Personas
{
    public partial class Form1 : Form
    {


        public static DataSet ejecuta(string cmd)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=minisistema");
            connection.Open();
            MySqlDataAdapter mySqlData = new MySqlDataAdapter(cmd, connection);
            DataSet dataset = new DataSet();

            mySqlData.Fill(dataset);
            connection.Close();
            return dataset;
        }

        //LOAD
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public Form1()
        {
            InitializeComponent();
        }

        Class1 consultas = new Class1();


      



        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

     

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //codigo para poder arrastrar la ventana por la pantalla




        //ACTUALIZAR
        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
        }


        //REGISTRAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }


        //ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

     

        private void btnConectar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
