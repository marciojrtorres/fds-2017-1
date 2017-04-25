using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = @"Data Source=" + Application.StartupPath + @"\app.sqlite3";
            var conexao = new SQLiteConnection(connectionString);

            var insert = @"INSERT INTO contatos VALUES (@nome, @telefone, @email)";
            var comando = new SQLiteCommand(insert, conexao);
            comando.Parameters.AddWithValue("@nome", "Laura");
            comando.Parameters.AddWithValue("@telefone", "999888222");
            comando.Parameters.AddWithValue("@email", "laurete@mobilete.com");
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
            MessageBox.Show("Sucesssoooo!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var connectionString = @"Data Source=" + Application.StartupPath + @"\app.sqlite3";
            var conexao = new SQLiteConnection(connectionString);

            var select = @"SELECT * FROM contatos";
            var comando = new SQLiteCommand(select, conexao);
            conexao.Open();
            var leitor = comando.ExecuteReader();
            while(leitor.Read())
            {
                var linha = leitor["nome"] + ", " + leitor["telefone"] + ", " + leitor["email"];
                textBox1.AppendText(linha + "\n");
            }
            leitor.Close();
            conexao.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var connectionString = @"Data Source=" + Application.StartupPath + @"\app.sqlite3";
            var conexao = new SQLiteConnection(connectionString);

            var select = @"SELECT * FROM contatos";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(select, conexao);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            
        }
    }
}
