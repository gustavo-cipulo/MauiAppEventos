
namespace MauiAppEventos.Views
{
    public partial class ResumoEvento : ContentPage
    {
        public ResumoEvento()
        {
            InitializeComponent();
        }

        private async void Voltar_Clicked(
            object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
