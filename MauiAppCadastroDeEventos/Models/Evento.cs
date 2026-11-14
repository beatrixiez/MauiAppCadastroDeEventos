namespace MauiAppCadastroDeEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataTermino { get; set; } = DateTime.Now;
        public int NumeroParticipantes { get; set; }
        public double CustoParticipante { get; set; }

        public TimeSpan Duracao => DataTermino.Subtract(DataInicio);

        public int DuracaoEmDias => Duracao.Days;

        public double CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoParticipante;
            }
        }
    }
}
