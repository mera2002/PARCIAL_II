using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Parcial
{
    public partial class logincs : Form
    {
        public logincs()
        {
            InitializeComponent();
        }

        private void logincs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Account login = new Account();
            login._username = textBox1.Text;
            login._password = textBox2.Text;

            if (login.logeo())
            {
                MetroFramework.MetroMessageBox.Show(this,
               "BIENVENIDOS!", "INICIO DE SESION", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                login.Insertlog();
      
            }
            else


            {
                MetroFramework.MetroMessageBox.Show(this,
                          "Nombre de usuario O contraseña incorrecta", "INICIO DE SESION", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            if (textBox1.Text == "adm")
            {

                Administrador adm = new Administrador();
                adm.Show(); 

            }
            else


            {
                
                Usuario usuario = new Usuario();
                usuario.Show();

            }
        }
}
}

