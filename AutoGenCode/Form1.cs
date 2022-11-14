using System.Data;

namespace AutoGenCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private static string server;
        private static string user;
        private static string password;
        private Connection myConnect;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            server = txtIPAdd.Text;
            user = txtUsername.Text;
            password = txtPass.Text;
            myConnect = new Connection(server, user, password);
            try
            {
                DataTable schemas = myConnect.SchemasLoad();
                if (schemas.Rows.Count > 0)
                {
                    for (int i = 0; i < schemas.Rows.Count; i++)
                    {
                        cmbSchemas.Items.Add(schemas.Rows[i][0].ToString());
                    }
                    cmbSchemas.SelectedIndex = 0;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSchemas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenCode_Click(object sender, EventArgs e)
        {

        }

        ~Form1() { }
    }
}