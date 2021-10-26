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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != textBox6.Text)
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "LA CONTRASEÑA NO COINCIDE", "Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Account account = new Account();
                account._firstname = textBox1.Text;
                account._lastname = textBox2.Text;
                account._email = textBox3.Text;
                account._registerDate = DateTime.Now.ToString("ddd-MM-yyy");
                account._username = textBox4.Text;
                account._password = textBox5.Text;
                account.registro();
                MetroFramework.MetroMessageBox.Show(this,
                    "Usuario registrado", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logincs login = new logincs();
                login.Show(); 
            }
        }
    }
}
