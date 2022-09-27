namespace MyFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblfullname.Text = txtfirstname.Text + " " + txtlastname.Text;
            string firstname = txtfirstname.Text;
            string lastname = txtlastname.Text;

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            lblfullname.Text = null;
            txtfirstname.Text = null;
            txtlastname.Text = null;
        }
    }
}