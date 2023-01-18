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

namespace Semana6TC
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "http://127.0.0.1/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Semana6TC.datos> _post;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<Semana6TC.datos> post = JsonConvert.DeserializeObject<List<Semana6TC.datos>>(content);
            _post = new ObservableCollection<Semana6TC.datos>(post);

        }
    }
}
