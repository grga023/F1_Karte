using F1Karte.Aplikacija.Interfejsi;
using F1Karte.Aplikacija.Servisi;
using Autofac;
using F1Karte.Infrastruktura.Interfejsi;
using F1Karte.Infrastruktura.Repositozitorijumi;
using F1Karte.Infrastruktura.Context;

namespace F1Karte.UI
{
    internal static class Program
    {
        private static IContainer _container;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Build the dependency injection container
            var builder = new ContainerBuilder();
            builder.RegisterType<F1KarteDBContext>().InstancePerLifetimeScope();
            builder.RegisterType<KartaServis>().As<IKartaServis>();
            builder.RegisterType<ValidacioniServis>().As<IValidacioniServis>();
            builder.RegisterType<KartaRepozitorijum>().As<IKartaRepozitorijum>();
            builder.RegisterType<Form1>().As<Form>();
            // Register other dependencies here
            _container = builder.Build();

            // Resolve the main form from the container
            using (var form = _container.Resolve<Form>())
            {
                Application.Run(form);
            }
        }
    }
}