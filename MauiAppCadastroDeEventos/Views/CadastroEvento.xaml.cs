using MauiAppCadastroDeEventos.Models;

namespace MauiAppCadastroDeEventos.Views;

public partial class CadastroEvento : ContentPage
{
    public CadastroEvento()
    {
        InitializeComponent();

        dtpck_inicio.Date = DateTime.Now;
        dtpck_termino.Date = DateTime.Now.AddDays(1);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txt_nome.Text) || string.IsNullOrWhiteSpace(txt_local.Text))
            {
                await DisplayAlertAsync("Ops", "Por favor, preencha o nome e o local do evento.", "OK");
                return;
            }

            if (dtpck_termino.Date < dtpck_inicio.Date)
            {
                await DisplayAlertAsync("Erro", "A data de término não pode ser anterior à data de início.", "OK");
                return;
            }

            Evento evento = new Evento
            {
                Nome = txt_nome.Text,
                Local = txt_local.Text,
                DataInicio = dtpck_inicio.Date?? DateTime.Now,
                DataTermino = dtpck_termino.Date ?? DateTime.Now.AddDays(1),
                NumeroParticipantes = Convert.ToInt32(txt_participantes.Text),
                CustoParticipante = Convert.ToDouble(txt_custo.Text)
            };

            await Navigation.PushAsync(new ResumoEvento
            {
                BindingContext = evento
            });

        } catch (Exception ex)
        {
            await DisplayAlertAsync("Ops!", ex.Message, "OK");
        }
    }
}
