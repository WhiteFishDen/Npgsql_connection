using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string connString = "Host=localhost;Username=postgres;Password=123;Database=testDB";
            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show( "Connection is real!");
                    NpgsqlCommand npgsqlCommand = connection.CreateCommand();
                    npgsqlCommand.CommandText = "select * from public.employees";
                    NpgsqlDataReader reader =  npgsqlCommand.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataSet1.Tables.Add(dt);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dataSet1.Tables[0];
                    dataGridView1.Refresh();
                    npgsqlCommand.Cancel();
                    reader.Close();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
