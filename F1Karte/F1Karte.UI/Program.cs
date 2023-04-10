using F1Karte.Aplikacija.Interfejsi;
using F1Karte.Infrastruktura;
using Microsoft.Extensions.DependencyInjection;

namespace F1Karte.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IKartaServis aaa;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(aaa));
        }
    }
}