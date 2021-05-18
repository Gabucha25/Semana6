using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana6
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "http://192.168.1.10/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Semana6.Datos> _post;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<Semana6.Datos> posts = JsonConvert.DeserializeObject<List<Semana6.Datos>>(content);
            _post = new ObservableCollection<Semana6.Datos>(posts);

            MyListView.ItemsSource = _post;

        }

        private async void btnPost_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new InsertPost());
        }

        private async void btnPut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PutPost());
        }

        private async void btnDelete_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DeletePost());
        }

    }
}
