using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM_P_PROGII
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView.ColumnCount = 6;

            dataGridView.Columns[0].Name = "Nosaukums";
            dataGridView.Columns[0].DataPropertyName = "Nosaukums";
            dataGridView.Columns[1].Name = "Tips";
            dataGridView.Columns[1].DataPropertyName = "Tips";
            dataGridView.Columns[2].Name = "Daudzums";
            dataGridView.Columns[2].DataPropertyName = "Daudzums";
            dataGridView.Columns[3].Name = "CenaParGab";
            dataGridView.Columns[3].DataPropertyName = "CenaParGab";
            dataGridView.Columns[4].Name = "VaiPardots";
            dataGridView.Columns[4].DataPropertyName = "VaiPardotas";
            dataGridView.Columns[5].Name = "IegutaPelna";
            dataGridView.Columns[5].DataPropertyName = "IegutaPelna";

            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\data_base\noliktavasDB.mdb";
            string query = "SELECT * FROM NoliktavasMantas";

            OleDbConnection connection = new OleDbConnection(connectionString);

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = ds.Tables[0];

        }

        private void add_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(nosaukums.Text))
            {
                MessageBox.Show("Aizpildiet lauku nosaukums!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tips.Text))
            {
                MessageBox.Show("Aizpildiet lauku tips!");
                return;
            }

            if (string.IsNullOrWhiteSpace(daudzums.Text))
            {
                MessageBox.Show("Aizpildiet lauku daudzums!");
                return;
            }

            if (string.IsNullOrWhiteSpace(cenaParGab.Text))
            {
                MessageBox.Show("Aizpildiet lauku CenaParGab!");
                return;
            }

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\data_base\noliktavasDB.mdb";

            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO NoliktavasMantas (Nosaukums, Tips, Daudzums, CenaParGab) VALUES (@nosaukumsValue, @tipsValue, @daudzumsValue, @cenaParGabValue)";


            cmd.Parameters.AddWithValue("@nosaukumsValue", OleDbType.Char).Value = nosaukums.Text;
            cmd.Parameters.AddWithValue("@tipsValue", OleDbType.Char).Value = tips.Text;
            cmd.Parameters.AddWithValue("@daudzumsValue", OleDbType.Char).Value = daudzums.Text;
            cmd.Parameters.AddWithValue("@cenaParGabValue", OleDbType.Char).Value = cenaParGab.Text;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Values Added");


            conn.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\data_base\noliktavasDB.mdb";
            string query = "SELECT * FROM NoliktavasMantas";

            OleDbConnection connection = new OleDbConnection(connectionString);

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = ds.Tables[0];
        }
    }
}
