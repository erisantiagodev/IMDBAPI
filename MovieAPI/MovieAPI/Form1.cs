using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;

namespace MovieAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HttpClient ApiClient = new HttpClient();

        public async Task GetMovies()
        {
            var movie = new Movie();
            var apiKey = new ApiKey();

            movie.Title = title.Text;
            movie.Year = year.Text;

            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                string url = $"http://www.omdbapi.com/?apikey={apiKey.key}&t={movie.Title}&y={movie.Year}&plot=full";

                string response = await ApiClient.GetStringAsync(url);

                Movie movieObject = JsonConvert.DeserializeObject<Movie>(response);
                
                moviePlot.Text = movieObject.Plot;
                movieActors.Text = movieObject.Actors;
            }

            catch
            {
                MessageBox.Show("Please load the movie.");
            }
           
        }

        private async void search_Click(object sender, EventArgs e)
        {
            try
            {
                await GetMovies();
            }

            catch
            {
                moviePlot.Text = null;
            }
        }
    }
}
