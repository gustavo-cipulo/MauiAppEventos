
namespace MauiAppEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; } = "";
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; } = "";
        public decimal CustoPorParticipante { get; set; }

        // Calcula a diferença entre as datas
        public TimeSpan Duracao
        {
            get => DataTermino.Date - DataInicio.Date;
        }

        // Duração em dias
        public int DuracaoDias
        {
            get => Duracao.Days;
        }

        // Calcula o custo total do evento
        public decimal CustoTotal
        {
            get => NumeroParticipantes * CustoPorParticipante;
        }
    }
}
