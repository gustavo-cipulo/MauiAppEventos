
using System.Globalization;

namespace MauiAppEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CultureInfo.DefaultThreadCurrentCulture =
                new CultureInfo("pt-BR");

            CultureInfo.DefaultThreadCurrentUICulture =
                new CultureInfo("pt-BR");
        }

        protected override Window CreateWindow(
            IActivationState? activationState)
        {
            var window = new Window(
                new NavigationPage(new MainPage())
            );

            window.Width = 520;
            window.Height = 750;

            return window;
        }
    }
}
