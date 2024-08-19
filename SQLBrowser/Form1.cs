using System.Data;
using System.Data.SqlClient;

namespace SQLBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string connectionString = string.Empty;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            CreateConnectionString("Master");

            try
            {
                cmbDatabases.Items.Clear();

                SQLHelper helper = new SQLHelper(connectionString);
                MessageBox.Show("Connected to SQL Server successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                helper.Command.CommandText = "SELECT NAME FROM SYS.DATABASES";
                List<string> results = helper.GetDataList();
                
                foreach (string item in results)
                {
                    this.cmbDatabases.Items.Add(item);
                }
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
            string dbName = cmbDatabases.SelectedItem.ToString();
            this.CreateConnectionString(dbName);

            try
            {
                cmbTables.Items.Clear();

                SQLHelper helper = new SQLHelper(connectionString);
                helper.Command.CommandText = "SELECT NAME FROM SYS.TABLES";
                List<string> results = helper.GetDataList();

                foreach (string item in results)
                {
                    this.cmbTables.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbName = cmbDatabases.SelectedItem.ToString();

            try
            {
                // List the columns of the selected table
                clbColumns.Items.Clear();

                SQLHelper helper = new SQLHelper(connectionString);
                helper.Command.CommandText = string.Format("SELECT COLUMN_NAME FROM {0}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TableName", dbName);
                helper.Command.Parameters.AddWithValue("@TableName", cmbTables.Text);
                List<string> results = helper.GetDataList();

                foreach (string item in results)
                {
                    this.clbColumns.Items.Add(item);
                }

                // Apply SELECT query to the selected table
                helper = new SQLHelper(connectionString); // reset the helper object

                string query = string.Format("SELECT * FROM {0}", cmbTables.Text);
                helper.Command.CommandText = query;
                txtQuery.Text = query;

                dgvResults.DataSource = helper.GetDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                SQLHelper helper = new SQLHelper(connectionString);

                helper.Command.CommandText = txtQuery.Text;

                dgvResults.DataSource = helper.GetDataTable();
            }
            catch (Exception ex)
            {
                if (connectionString.Equals(string.Empty))
                {
                    MessageBox.Show("Please connect to a server.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please select a database and table to operate on.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void clbColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbName = cmbDatabases.SelectedItem.ToString();

            try
            {
                string query = string.Empty;
                string columns = string.Empty;

                if (clbColumns.CheckedItems.Count > 0)
                {
                    foreach (object item in clbColumns.CheckedItems)
                    {
                        columns += string.Format("[{0}],", item.ToString());
                    }

                    columns = columns.TrimEnd(',');
                }
                else
                {
                    columns = "*";
                }

                SQLHelper helper = new SQLHelper(connectionString);

                query = string.Format("SELECT {0} FROM {1}", columns, cmbTables.Text);
                helper.Command.CommandText = query;
                txtQuery.Text = query;

                dgvResults.DataSource = helper.GetDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Helper method to create the connection string
        private void CreateConnectionString(string dbName)
        {
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
        }
    }
}
