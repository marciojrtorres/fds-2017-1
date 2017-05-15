using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_ef_databinding
{
    public partial class FormContatos : Form
    {
        AgendaContext ctx;

        public FormContatos()
        {
            InitializeComponent();
        }

        private void FormContatos_Load(object sender, EventArgs e)
        {
            ctx = new AgendaContext();
            ctx.Contato.Load();
            contatoBindingSource.DataSource =
                ctx.Contato.Local.ToBindingList();
        }

        private void contatoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
            contatoDataGridView.Refresh();
            telefoneDataGridView.Refresh();
        }
    }
}
