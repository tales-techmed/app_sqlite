using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using app_sqlite.BancoDeDados;
using System.IO;
using app_sqlite.Droid.BancoDeDados;

[assembly:Dependency(typeof(CaminhoDoBanco))]
namespace app_sqlite.Droid.BancoDeDados
{
    public class CaminhoDoBanco : I_LocalDados
    {
        public string getCaminho(string nomedoarquivo)
        {
            string path = System.Environment.GetFolderPath(
                System.Environment.SpecialFolder.Personal);
            string arquivo = Path.Combine(path, nomedoarquivo);
            return arquivo;
        }
    }
}