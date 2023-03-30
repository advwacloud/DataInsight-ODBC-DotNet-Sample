using System.Data;
using System.Data.Odbc;
using System.Drawing;

namespace HiveConnector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OdbcConnection _conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnExecute.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblStatus.BackColor != Color.Green) // connect
                {
                    if (txtDSN.Text == "")
                    {
                        MessageBox.Show("Please enter DSN first !");
                        txtDSN.Focus();
                        return;
                    }
                    string connetionString = $"DSN={txtDSN.Text};";
                    _conn = new OdbcConnection(connetionString);
                    _conn.Open();
                    lblStatus.BackColor = Color.Green;
                    btnConnect.Text = "Disconnect";
                    btnExecute.Enabled = true;
                }
                else // disconnect
                {
                    _conn.Close();
                    lblStatus.BackColor = Color.Gray;
                    btnConnect.Text = "Connect";
                    btnExecute.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSQL.Text == "")
                {
                    MessageBox.Show("Please enter SQL first !");
                    txtSQL.Focus();
                    return;
                }
                using (OdbcDataAdapter dadapter = new OdbcDataAdapter(txtSQL.Text, _conn))
                {
                    DataTable table = new DataTable();
                    dadapter.Fill(table);
                    this.dgvODBC.DataSource = table;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}