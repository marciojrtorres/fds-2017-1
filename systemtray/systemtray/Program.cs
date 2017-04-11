using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using systemtray.Properties;

namespace systemtray
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var url = @"http://www.cinesystem.com.br/praca-rio-grande/programacao";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            var nodes = doc.DocumentNode.SelectNodes("//td");
            //Console.WriteLine(nodes[0].InnerText);
            var str = "";
            if (nodes != null)
            foreach (var node in nodes)
            {
                if (node.InnerText.Length > 0)
                {
                        var line = Regex.Replace(node.InnerText, @"[\t\r\n]+", "")
                            .Trim();
                    // if (line.Length > 0) Console.WriteLine((int) line[0]);
                    str += line + "EOL \n";
                    //break;
                }

                // att.Value = FixLink(att);
            }
            Console.WriteLine(str);

            /*
            Process p =Process.Start("http://google.com");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            Application.Run(new AppContext());
            */
        }
    }

    delegate void OnChange(EventArgs args);

    class AppContext : ApplicationContext
    {
        NotifyIcon ic;
        Thread t;

       void Teste(EventArgs e)
        {

        }

        public AppContext()
        {
            OnChange c = (args) => Console.WriteLine(); ;
            ic = new NotifyIcon
            {
                Icon = Resources.AppIcon,
                ContextMenu = new ContextMenu(new MenuItem[]
                {
                    new MenuItem("Exit", new EventHandler(Exit))
                }),
                Visible = true
            };

            t = new Thread(Loop);
            t.Start();            
        }

        void Loop()
        {
            
            while (true)
            {
                ic.BalloonTipText = "TESTE";
                ic.ShowBalloonTip(1000, "YHA", "A",ToolTipIcon.Info);
                Thread.Sleep(5000);
                var url = @"http://www.cinesystem.com.br/praca-rio-grande/programacao";
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);
                var nodes = doc.DocumentNode.SelectNodes("//td");
                //Console.WriteLine(nodes[0].InnerText);
                var str = "";
                foreach (var node in nodes)
                {
                    if (node.InnerText.Length > 0)
                    {
                        str = Regex.Replace(node.InnerText, @"[\n\t\r]+", "").Trim();
                        break;
                    }
                        
                    // att.Value = FixLink(att);
                }
                ic.ContextMenu.MenuItems.Add(str);                
            }
        }

        void Exit(object sender, EventArgs e)
        {
            ic.Visible = false;

            Application.ExitThread();
            System.Environment.Exit(0);
        }
    }
}
