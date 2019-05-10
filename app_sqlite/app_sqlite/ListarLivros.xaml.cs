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
		public ListarLivros ()
		{
			InitializeComponent ();
            AcessoBD banco = new AcessoBD();
            listagem.ItemsSource = banco.Consultar();
		}

        private async void BtInserir_Clicked(object sender, EventArgs e)
        {            
            await Navigation.PushAsync(new CadastrarLivro());
        }
    }
}