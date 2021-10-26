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

namespace Parcial
{
    public partial class Administrador : Form
    {
        public Administrador()

       
        {
            InitializeComponent();
            
        }



        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Administrador_Load(object sender, EventArgs e)
        {

            fillDataGridView();
            Datafill();



        }

        public void fillDataGridView()

        {

            

           Account account = new Account();

            clearDataGridView();

            dataGridView1.Columns.Add("codUser", "COD USUARIO");
            dataGridView1.Columns.Add("firstname", "NOMBRE");
            dataGridView1.Columns.Add("lastname", "APELLIDO");
            dataGridView1.Columns.Add("email", "EMAIL");
            dataGridView1.Columns.Add("registerDate", "HORA DE REGISTRO");
            dataGridView1.Columns.Add("username", "NOMBRE DE USUARIO");
            dataGridView1.Columns.Add("password", "CONTRASEÑA");

        }

        public void Datafill()

        {

            Account account = new Account();

            clearDataGridVieew();

            dataGridView2.Columns.Add("codUser", "COD USUARIO");
            dataGridView2.Columns.Add("timeLoggedln", "HORA Y FECHA DE REGISTRO");
            dataGridView2.Columns.Add("username", "NOMBRE DE USUARIO");      

}

        private void button2_Click(object sender, EventArgs e)


        {
            Account account = new Account();
            MySqlDataReader dataReader = account.GetLog();

            while (dataReader.Read())
            {
                dataGridView2.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2)

                       );
            }


        }
        public void clearDataGridVieew()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            MySqlDataReader dataReader = account.getAll();

            while (dataReader.Read())
            {
                dataGridView1.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4),
                        dataReader.GetValue(5),
                        dataReader.GetValue(6)
                       );
            }

        }
        public void clearDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
        }

        public void fillDataGridVieew()
        {
            Account account = new Account();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }
    }
    }



