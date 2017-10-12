using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace StakeOut
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestService : ContentPage
    {
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        private ObservableCollection<RestService> _posts;

        public RestService()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            {
                var content = await _client.GetStringAsync(Url);
                var posts = JsonConvert.DeserializeObject<List<RestService>(content);
                _posts = new ObservableCollection<RestService>(posts);
                postsListView.ItemsSource = _posts;
                base.OnAppearing();
            }
        }
    }
}