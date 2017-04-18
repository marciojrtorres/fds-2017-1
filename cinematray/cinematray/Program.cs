using cinematray.Properties;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinematray
{
    class Tray : ApplicationContext
    {
        NotifyIcon icon;

        void Sair(object o, EventArgs evt)
        {
            Application.Exit();
        }

        void YouTube(object o, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://youtu.be");
        }

        void CarregaFilmes()
        {
            var url = "http://www.cinesystem.com.br/praca-rio-grande/programacao";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            var nodes = doc.DocumentNode
                            .SelectNodes("//td[@class='name']");
            var filmes = new SortedSet<string>();
            foreach (var n in nodes) filmes.Add(n.InnerText.Trim());
            foreach (var f in filmes)
            {
                icon.ContextMenu.MenuItems.Add(f);
                icon.BalloonTipText += f + "\n";
            }
        }

        public Tray()
        {
            icon = new NotifyIcon
            {
                Icon = Properties.Resources.AppIcon,
                ContextMenu = new ContextMenu(
                    new MenuItem[]
                    {
                        new MenuItem("Sair", Sair),
                        new MenuItem("YouTube", YouTube)
                    }
                ),
                Visible = true
            };
            icon.BalloonTipIcon = ToolTipIcon.Info;
            icon.BalloonTipTitle = "Filmes em cartaz";
            // icon.BalloonTipText = "os filmes ...";            
            CarregaFilmes();
            icon.ShowBalloonTip(1);
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tray());                        
        }
    }
}
