using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            string connString = "Host=localhost;Username=postgres;Password=123;Database=postgres";
            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand npgsqlCommand = connection.CreateCommand();
                    npgsqlCommand.CommandText = "select * from public.teachers";
                    NpgsqlDataReader reader =  npgsqlCommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataSet1.Tables.Add(dt); 
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dataSet1.Tables[0];
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

        private void button_go_query_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=123;Database=postgres";
            string command = textBox_query.Text;
            using (DbDataAdapter dbDataAdapter = new NpgsqlDataAdapter(command, connString))
            {
                try
                {
                    dbDataAdapter.Fill(dataSet1.Tables.Add());
                    dataGridView1.DataSource = dataSet1.Tables[dataSet1.Tables.Count - 1];
                    if (Check_history())
                        comboBox_save_query.Items.Add(textBox_query.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
            }
        }
        private bool Check_history()
        {
            for (int i = 0; i < comboBox_save_query.Items.Count; i++)
            {
                if (comboBox_save_query.Items.Count == 0)
                    return true;
                if (textBox_query.Text == comboBox_save_query.Items[i].ToString())
                    return false; 
            }
            return true;
        }
        private void comboBox_save_query_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_query.Text = comboBox_save_query.SelectedItem.ToString();
            button_go_query_Click(sender, e);
        }
    }
}
