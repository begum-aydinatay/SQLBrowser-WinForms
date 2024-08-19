using System.Data.SqlClient;

namespace SQLBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = string.Empty;

            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                // SQL Authentication
                connectionString = string.Format(@"Server={0};Database=Master;User Id={1};Password={2}; TrustServerCertificate=True;", txtServerName.Text, txtUsername.Text, txtPassword.Text);
            }
            else
            {
                // Windows Authentication
                connectionString = string.Format(@"Server={0};Database=Master;Trusted_Connection=True;Encrypt=false; TrustServerCertificate=True; Integrated Security=True", txtServerName.Text);
            }

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();
                MessageBox.Show("Connected to SQL Server successfully.");
                conn.Close();
                MessageBox.Show("Connection to SQL Server closed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
