using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBase_Curso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string conexion = "SERVER= 127.0.0.1; PORT = 3306; DATABASE = informacion_curso; UID = root; PASSWORD=''";
        MySqlConnection CN = new MySqlConnection(conexion);

        public DataTable llenar_grid()
        {
            CN.Open();
            DataTable DT = new DataTable();
            string LLENAR = "SELECT * FROM `curso`";
            MySqlCommand comd = new MySqlCommand(LLENAR, CN);
            MySqlDataAdapter adap = new MySqlDataAdapter(comd);
            adap.Fill(DT);
            CN.Close();
            return DT;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            CN.Open();
            string ELIMINAR = "DELETE FROM curso WHERE `ID_CURSO` = '" + TxtId_Curso.Text + "'";
            MySqlCommand comd = new MySqlCommand(ELIMINAR, CN);
            comd.Parameters.AddWithValue("id_curso", TxtId_Curso.Text);
            comd.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("los datos fueron borrardos");
            dataGridView1.DataSource = llenar_grid();
        }

        private void BtnGuardarDataCurso_Click(object sender, EventArgs e)
        {
            CN.Open();
            string insertar = "INSERT INTO `curso`(`ID_CURSO`, `NOMBRE`, `INSTRUCTOR`,`APELLIDOS INSTRUCTOR`) VALUES ('" + TxtId_Curso.Text + "','" + TxtnameCurso.Text + "','" + TxtnombreInstructor.Text + "', '" + TxtapellidosInstructor.Text + "')";
            MySqlCommand ncomd = new MySqlCommand(insertar, CN);

            ncomd.Parameters.AddWithValue("ID_CURSO", TxtId_Curso.Text);
            ncomd.Parameters.AddWithValue("NOMBRE", TxtnameCurso.Text);
            ncomd.Parameters.AddWithValue("INSTRUCTOR", TxtnombreInstructor.Text);
            ncomd.Parameters.AddWithValue("APELLIDOS_INSTRUCTOR", TxtapellidosInstructor.Text);
            ncomd.ExecuteNonQuery();

            CN.Close();

            MessageBox.Show("datos agregados exitosamente");

            dataGridView1.DataSource = llenar_grid();
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            CN.Open();
            string AGREGAR = "UPDATE `curso` SET `ID_CURSO`='" + TxtId_Curso.Text + "',`NOMBRE`='" + TxtnameCurso.Text + "',`INSTRUCTOR`='" + TxtnombreInstructor.Text + "',`APELLIDOS INSTRUCTOR`='" + TxtapellidosInstructor.Text + "' WHERE 1";

        }
    }
}
