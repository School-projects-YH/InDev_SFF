using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFF.Datasource.Model;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace SFFWebpage.Data
{
    public class MovieService
    {
        public async Task<Movie[]> GetMoviesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var photoJson = await client.GetStringAsync("https://localhost:5001/api/Movie");
                List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(photoJson);
                return movies.ToArray();
            }
        }

        public async void RentMovieAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                var json = await client.GetStringAsync("https://localhost:5001/api/Movie/" + id);
                var movie = JsonConvert.DeserializeObject<Movie>(json);
                movie.NumberOfCurrentlyRented += 1;
                json = JsonConvert.SerializeObject(movie);
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                await client.PutAsync("https://localhost:5001/api/Movie/" + id, httpContent);
                
            }
        }
    }
}
