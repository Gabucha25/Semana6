using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertPost : ContentPage
    {
        public InsertPost()
        {
            InitializeComponent();
        }

        private async void btnInsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();

                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtApellido.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);

                cliente.UploadValues("http://192.168.1.10/moviles/post.php", "POST", parametros);

                //await DisplayAlert("Alerta", "Dato ingresado con exito", "OK");
                //Mensaje TOAST
                var mensaje = "Dato ingresado con exito";
                DependencyService.Get<Mensaje>().LongAlert(mensaje);

                //Limpiar cajas de texto
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
            }
            catch(Exception ex)
            {
                //await DisplayAlert("Alerta", "Error: " + ex.Message, "OK");
                //Mensaje TOAST
                DependencyService.Get<Mensaje>().ShortAlert(ex.ToString());

                //Limpiar cajas de texto
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
            }
        }

        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}