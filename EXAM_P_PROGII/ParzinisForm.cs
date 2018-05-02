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
    public partial class ParzinisForm : Form
    {
        public ParzinisForm()
        {
            InitializeComponent();
        }

        private void ParzinisForm_Load(object sender, EventArgs e)
        {
            dataParzinis.ColumnCount = 2;

            dataParzinis.Columns[0].Name = "Klients";
            dataParzinis.Columns[0].DataPropertyName = "Klients";
            dataParzinis.Columns[1].Name = "Nosaukums";
            dataParzinis.Columns[1].DataPropertyName = "Nosaukums";


            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\data_base\noliktavasDB.mdb";
            string query = "SELECT * FROM NoliktavasMantas";

            OleDbConnection connection = new OleDbConnection(connectionString);

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataParzinis.AutoGenerateColumns = false;
            dataParzinis.DataSource = ds.Tables[0];
        }
    }
}
