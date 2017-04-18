using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoSecretoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Participantes = new BindingList<String>();            
            this.lbParticipantes.DataSource = this.Participantes;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            this.Participantes.Add(tbNome.Text);
            tbNome.Clear();
            tbNome.Focus();
        }

        public BindingList<String> Participantes { get; set; }
        List<string> nova = new List<string>();

        private void btSortear_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>(this.Participantes);
            lista.Shuffle();
            Stack<string> pilha = new Stack<string>(lista);
            nova = new List<string>();
            string par = "";
            while (pilha.Count > 0)
            {
                if (string.IsNullOrEmpty(par))
                {
                    par += pilha.Pop();
                } else
                {
                    par += ", " + pilha.Peek();
                    nova.Add(par);
                    par = "";
                }
            }
            nova.Add(lista.First() + ", " + lista.Last());
            lbSorteados.DataSource = nova;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posicao = lbParticipantes.SelectedIndex;
            if (posicao >= 0)
            {
                this.Participantes.RemoveAt(posicao);
            }
        }

        private void btCopiar_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            foreach (var linha in nova) sb.AppendLine(linha);           
            Clipboard.SetText(sb.ToString());

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            foreach (var linha in nova) sb.AppendLine(linha);
            SaveFileDialog saveDialog = new SaveFileDialog();
            // saveDialog.Filter = "*.txt";
            saveDialog.ShowDialog(this);
            if (!string.IsNullOrEmpty(saveDialog.FileName))
                using (Stream st = saveDialog.OpenFile())
                    using (StreamWriter sw = new StreamWriter(st))
                        sw.Write(sb.ToString());
                        
        }
    }
}
