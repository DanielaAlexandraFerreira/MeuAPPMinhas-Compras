using MeuAPPMinhas_Compras.Models;

namespace MeuAPPMinhas_Compras.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto p = new Produto
			{
				Descricao = txt_decricao.Text,
				Quantidade = Convert.ToDouble(txt_quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text)
			};

			await App.Db.Insert(p);
			await DisplayAlert("sucesso!", "Registro Inserido", "OK");
			await Navigation.PopToRootAsync();


		} catch(Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }
}