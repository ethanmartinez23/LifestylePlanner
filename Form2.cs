using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifestylePlanner
{
    public partial class regForm : Form
    {
        public regForm()
        {
            InitializeComponent();
        }

        private void regForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            logInForm logIn = new logInForm();
            regForm register = new regForm();
            var regForm = new regForm();
            this.Hide();
            regForm.Closed += (s, args) => this.Close();
            logIn.Show();
        }
    }
}
