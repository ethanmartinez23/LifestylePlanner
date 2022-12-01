namespace LifestylePlanner
{
    public partial class logInForm : Form
    {
        public logInForm()
        {
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logInForm logIn = new logInForm();
            regForm register = new regForm();
            var regForm = new regForm();
            this.Hide();
            regForm.Closed += (s, args) => this.Close();
            register.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 welcome = new Form3();
            logInForm logIn = new logInForm();
            regForm register = new regForm();
            var regForm = new regForm();
            this.Hide();
            regForm.Closed += (s, args) => this.Close();
            welcome.Show();
        }
    }
}