using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using app_sqlite.BancoDeDados;
using app_sqlite.Modelo;

namespace app_sqlite
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListarLivros : ContentPage
	{
        List<Livro> ListaDeDados { get; set; }

		public ListarLivros ()
		{
			InitializeComponent ();
            AcessoBD banco = new AcessoBD();
            ListaDeDados = banco.Consultar();
            listagem.ItemsSource = ListaDeDados;
		}

        private async void BtInserir_Clicked(object sender, EventArgs e)
        {            
            await Navigation.PushAsync(new CadastrarLivro());
        }

        private void EditarAction(object sender, EventArgs e)
        {
            Label lblEditar = (Label)sender;
            TapGestureRecognizer tgr = (TapGestureRecognizer)lblEditar.GestureRecognizers[0];
            Livro livro = tgr.CommandParameter as Livro;
            Navigation.PushAsync(new EditarLivro(livro));
        }

        private void ExcluirAction(object sender, EventArgs e)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tgr = (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];
            Livro livro = tgr.CommandParameter as Livro;
            Navigation.PushAsync(new ExcluirLivro(livro));
        }

        private void Pesquisa_TextChanged(object sender, TextChangedEventArgs e)
        {
            listagem.ItemsSource = ListaDeDados.Where(a => a.titulo.Contains(e.NewTextValue) ||
                                                           a.autor.Contains(e.NewTextValue)).ToList();
        }
    }
}