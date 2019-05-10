using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using app_sqlite.Modelo;
using app_sqlite.BancoDeDados;

namespace app_sqlite
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastrarLivro : ContentPage
	{
		public CadastrarLivro ()
		{
			InitializeComponent ();
		}

        private void BtSalvar_Clicked(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livro.titulo = titulo.Text;
            livro.autor = autor.Text;
            AcessoBD banco = new AcessoBD();
            banco.Inserir(livro);
            App.Current.MainPage = new NavigationPage(new ListarLivros());
        }
    }
}