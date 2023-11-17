using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using System.Net.Http;
using Newtonsoft;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace PDC06_Module08
{
    public class Post
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        public const string url = "http://172.16.24.189/pdc6/api_create.php";
        private HttpClient _Client = new HttpClient();
        private ObservableCollection<Post> _post;



        public MainPage()
        {
            InitializeComponent();

        }
        private async void OnAdd(object sender, System.EventArgs e)
        {

            Post post = new Post { username = xUsername.Text, password = xPassword.Text };
            var content = JsonConvert.SerializeObject(post);
            await _Client.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json"));
        }

    }
}
