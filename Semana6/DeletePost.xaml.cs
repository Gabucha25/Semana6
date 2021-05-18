using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeletePost : ContentPage
    {
        private const string Url = "http://192.168.1.10/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Semana6.Datos> _post;

        public DeletePost()
        {
            InitializeComponent();
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}