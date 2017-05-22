using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_binding_validacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cliente cliente;

        private void Form1_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();
            clienteBindingSource.DataSource = cliente;            
            tbCEP.DataBindings
                .Add("Text", clienteBindingSource, "CEP");
            tbCPF.DataBindings
                .Add("Text", clienteBindingSource, "CPF");
        }
        // Aspect Oriented Programming
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                // aqui é seguro salvar
                MessageBox.Show(cliente.ToString());
            } else
            {
                MessageBox.Show(this,
                    "Um ou mais campos contém erros",
                    "Opa!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void codigoTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (int.Parse(codigoTextBox.Text) <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(box, "Código inválido, necessário um número positivo");
            }
        }

        private void codigoTextBox_Validated(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            errorProvider1.SetError(box, "");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void nomeTextBox_Validating(object sender, CancelEventArgs e)
        {
            // if 5 > nomeTextBox.Text.Length > 50           
            if (nomeTextBox.Text.Length < 5 
                || nomeTextBox.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(nomeTextBox, "O nome deve ter entre 5 e 50 caracteres");
            } else
            {
                errorProvider1.SetError(nomeTextBox, "");
            }
        }
    }
}
