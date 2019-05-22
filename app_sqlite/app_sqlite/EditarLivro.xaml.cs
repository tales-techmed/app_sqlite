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
    public partial class EditarLivro : ContentPage
    {
        private Livro livro { get; set; }

        public EditarLivro(Livro livro)
        {
            InitializeComponent();
            this.livro = livro;
            id.Text = livro.id.ToString();
            titulo.Text = livro.titulo;
            autor.Text = livro.autor;
        }

        private void BtSalvar_Clicked(object sender, EventArgs e)
        {
            livro.titulo = titulo.Text;
            livro.autor = autor.Text;
            AcessoBD banco = new AcessoBD();
            banco.Atualizar(livro);
            App.Current.MainPage = new NavigationPage(new ListarLivros());
        }
    }
}