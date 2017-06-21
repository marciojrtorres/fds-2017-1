using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FiscalPrinterBematech;

namespace cobaiadll
{
    public partial class Form1 : Form
    {

        const int MOD_ALT = 0x0001;
        const int MOD_CTRL = 0x0002;
        const int MOD_SHIFT = 0x0004;
        const int MOD_WIN = 0x0008;

        public Form1()
        {
            InitializeComponent();
            RegistrarAtalho();
        }

        [DllImport("user32.dll")]
        public static extern bool 
            RegisterHotKey(IntPtr handle, int id, 
                           int modificadores, int key);

        private void RegistrarAtalho()
        {
            bool sucesso = RegisterHotKey(this.Handle, 3322,
                MOD_CTRL, (int) Keys.F12);

            if (sucesso) MessageBox.Show("Sucessoooo");
            
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312) textBox1.Text += " pressed";
            
            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BemaFI32.Bematech_FI_AbreCupom("");
            BemaFI32.Bematech_FI_VendeItem("77338834",
                "Bolinho", "FF", "I", "2", 
                2, "3,30", "%", "0");            
            BemaFI32.Bematech_FI_IniciaFechamentoCupom(
                "A", "%", "0");
            BemaFI32.Bematech_FI_EfetuaFormaPagamento(
                "Dinheiro", "50,00");
            BemaFI32.Bematech_FI_TerminaFechamentoCupom(
                "Volte sempre");
        }
    }
}
