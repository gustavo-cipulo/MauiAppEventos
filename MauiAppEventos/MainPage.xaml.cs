
using MauiAppEventos.Models;
using MauiAppEventos.Views;
using System.Globalization;

namespace MauiAppEventos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            DateTime hoje = DateTime.Today;

            dtp_inicio.Date = hoje;
            dtp_termino.Date = hoje.AddDays(1);
            dtp_termino.MinimumDate = hoje;
        }

        private void dtp_inicio_DateSelected(
            object sender, DateChangedEventArgs e)
        {
            DateTime inicio = e.NewDate ?? DateTime.Today;

            dtp_termino.MinimumDate = inicio;

            if ((dtp_termino.Date ?? inicio) < inicio)
            {
                dtp_termino.Date = inicio;
            }
        }

        private async void Cadastrar_Clicked(
            object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ent_nome.Text))
            {
                await DisplayAlertAsync(
                    "Atenção",
                    "Informe o nome do evento.",
                    "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(ent_local.Text))
            {
                await DisplayAlertAsync(
                    "Atenção",
                    "Informe o local do evento.",
                    "OK");
                return;
            }

            if (!int.TryParse(
                ent_participantes.Text,
                out int participantes) || participantes <= 0)
            {
                await DisplayAlertAsync(
                    "Atenção",
                    "Informe um número válido de participantes.",
                    "OK");
                return;
            }

            var culturaBR = new CultureInfo("pt-BR");

            if (!decimal.TryParse(
                ent_custo.Text,
                NumberStyles.Number,
                culturaBR,
                out decimal custo) || custo < 0)
            {
                await DisplayAlertAsync(
                    "Atenção",
                    "Informe um custo válido. Exemplo: 25,50",
                    "OK");
                return;
            }

            DateTime inicioEvento =
                dtp_inicio.Date ?? DateTime.Today;

            DateTime terminoEvento =
                dtp_termino.Date ?? DateTime.Today;

            if (terminoEvento < inicioEvento)
            {
                await DisplayAlertAsync(
                    "Atenção",
                    "A data de término não pode ser anterior à data de início.",
                    "OK");
                return;
            }

            Evento evento = new Evento
            {
                Nome = ent_nome.Text.Trim(),
                DataInicio = inicioEvento,
                DataTermino = terminoEvento,
                NumeroParticipantes = participantes,
                Local = ent_local.Text.Trim(),
                CustoPorParticipante = custo
            };

            await Navigation.PushAsync(
                new ResumoEvento
                {
                    BindingContext = evento
                });
        }
    }
}
