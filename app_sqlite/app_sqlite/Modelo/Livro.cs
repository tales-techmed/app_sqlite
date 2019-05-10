using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace app_sqlite.Modelo
{
    [Table("Livros")]
    public class Livro
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
    }
}
