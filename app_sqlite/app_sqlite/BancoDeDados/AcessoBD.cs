using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using app_sqlite.Modelo;
using SQLite;
using System.Linq;

namespace app_sqlite.BancoDeDados
{
    class AcessoBD
    {
        private SQLiteConnection conexao;

        public AcessoBD()
        {
            var dep = DependencyService.Get<I_LocalDados>();
            string arquivo = dep.getCaminho("bancodedados.sqlite");
            conexao = new SQLiteConnection(arquivo);
            conexao.CreateTable<Livro>();
        }

        public void Inserir (Livro livro)
        {
            conexao.Insert(livro);
        }

        public void atualizar(Livro livro)
        {

        }

        public void excluir(int idlivro)
        {

        }

        public List<Livro> Consultar()
        {
            return conexao.Table<Livro>().ToList();
        }

        public Livro ObterLivroPorId(int id)
        {
            return null;
        }

    }
}
