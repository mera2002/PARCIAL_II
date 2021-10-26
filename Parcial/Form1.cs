using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{

    //INTEGRANTES 
    // - NATHALY SARAI RODRIGUEZ SILVA 
    // - MERARY JULISSA ARAUJO VELASQUEZ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register register = new register();
            register.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            logincs login = new logincs();
            login.Show();
        }
    }
}
