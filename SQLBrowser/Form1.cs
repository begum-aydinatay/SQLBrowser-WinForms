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

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM SYS.DATABASES";

                cmbDatabases.Items.Clear();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string dbName = reader.GetString(0);
                    this.cmbDatabases.Items.Add(dbName);
                }

                reader.Close();
                reader.Dispose();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtServerName.Text = @".\SQLEXPRESS";
        }

        private void cmbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {

            string connectionString = string.Empty;
            string dbName = cmbDatabases.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                // SQL Authentication
                connectionString = string.Format(@"Server={0};Database={1};User Id={2};Password={3}; TrustServerCertificate=True;", txtServerName.Text, dbName, txtUsername.Text, txtPassword.Text);
            }
            else
            {
                // Windows Authentication
                connectionString = string.Format(@"Server={0};Database={1};Trusted_Connection=True;Encrypt=false; TrustServerCertificate=True; Integrated Security=True", txtServerName.Text, dbName);
            }

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT NAME FROM SYS.TABLES";

                cmbTables.Items.Clear();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string tName = reader.GetString(0); // get the table names from the 'Name' column 
                    this.cmbTables.Items.Add(tName);
                }

                reader.Close();
                reader.Dispose();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
