using MauiAppCadastroDeEventos.Models;

namespace MauiAppCadastroDeEventos.Views;

public partial class ResumoEvento : ContentPage
{
	public ResumoEvento()
	{
		InitializeComponent();
	}

	private async void OnVoltarClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}