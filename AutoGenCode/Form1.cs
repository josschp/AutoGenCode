using System.Data;

namespace AutoGenCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Connection myConnect = new Connection();

        private void btnConnect_Click(object sender, EventArgs e)
        {
            myConnect = new Connection(txtIPAdd.Text, txtUsername.Text, txtPass.Text);
            try
            {
                MessageBox.Show("Connected successfully to the Server");
                DataTable schemas = myConnect.SchemasLoad();
                if (schemas.Rows.Count > 0)
                {
                    cmbSchemas.Items.Clear();
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
            try
            {
                DataTable tableName = myConnect.GetTableName(cmbSchemas.Text);
                if(tableName != null)
                {
                    cmbTables.Items.Clear();
                    for(int i = 0; i<tableName.Rows.Count; i++)
                    {
                        cmbTables.Items.Add(tableName.Rows[i][0].ToString());
                    }
                    cmbTables.SelectedIndex = 0;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = myConnect.GetField(cmbSchemas.Text, cmbTables.Text);
                if(dt != null)
                {
                    dtgView.DataSource = dt;
                }
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenCode_Click(object sender, EventArgs e)
        {
            try
            {
                ModelGenText mdg = new ModelGenText(txtProjext.Text, txtIPAdd.Text, txtUsername.Text, txtPass.Text);
                MessageBox.Show(mdg.GenModel(cmbSchemas.Text, DirectoryPath()));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static string DirectoryPath()
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                // ...
                return Path.GetDirectoryName(folderBrowser.FileName) + "";
            }
            return @"D:\Softs\Coding Training\C#\CodeGened";
        }

        ~Form1() { }
    }
}