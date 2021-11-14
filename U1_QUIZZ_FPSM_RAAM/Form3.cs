using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Globalization;
using Newtonsoft.Json.Converters;

namespace U1_QUIZZ_FPSM_RAAM
{
    public partial class Form3 : Form
    {

        HttpClient client = new HttpClient();
        public Form3()
        {
            InitializeComponent();
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            string response = await client.GetStringAsync("https://api.themoviedb.org/3/movie/popular?api_key=550bae983aa83674f9aafbcc6085c3cb");
            Movies peliculas = JsonConvert.DeserializeObject<Movies>(response);
            Console.WriteLine(peliculas.Results[1].Overview);
            foreach (var movies in peliculas.Results)
            {
                      
                string parsedId = Convert.ToString(movies.Id);
                string parsedTitle = movies.OriginalTitle;
                string parsedOverview = movies.Overview;
                string parsedAdult = Convert.ToString(movies.Adult);
                string parsedPopularity = Convert.ToString(movies.Popularity);
                string parsedOriginalLanguague = movies.OriginalLanguage;
                string[] row = { parsedId, parsedTitle, parsedOverview, parsedAdult, parsedPopularity, parsedOriginalLanguague };
                var listViewItems = new ListViewItem(row);
                listView1.Items.Add(listViewItems);
            }
            label1.Text = Form2.valueText2;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public partial class Movies
        {
            [JsonProperty("page")]
            public long Page { get; set; }

            [JsonProperty("results")]
            public Result[] Results { get; set; }

            [JsonProperty("total_pages")]
            public long TotalPages { get; set; }

            [JsonProperty("total_results")]
            public long TotalResults { get; set; }
        }
        public partial class Result
        {
            [JsonProperty("adult")]
            public bool Adult { get; set; }

            [JsonProperty("backdrop_path")]
            public string BackdropPath { get; set; }

            [JsonProperty("genre_ids")]
            public long[] GenreIds { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("original_language")]
            public string OriginalLanguage { get; set; }

            [JsonProperty("original_title")]
            public string OriginalTitle { get; set; }

            [JsonProperty("overview")]
            public string Overview { get; set; }

            [JsonProperty("popularity")]
            public double Popularity { get; set; }

            [JsonProperty("poster_path")]
            public string PosterPath { get; set; }

            [JsonProperty("release_date")]
            public DateTimeOffset ReleaseDate { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("video")]
            public bool Video { get; set; }

            [JsonProperty("vote_average")]
            public double VoteAverage { get; set; }

            [JsonProperty("vote_count")]
            public long VoteCount { get; set; }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EQUIPO_AV --- FEDRA PAULINA --- RICARDO ALEXIS --- IBM901");
                        
        }
    }
}
