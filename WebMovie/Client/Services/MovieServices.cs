using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebMovie.Shared;

namespace WebMovie.Client.Services
{
    public class MovieServices : IMovieServices
    {
        readonly HttpClient _httpClient;

        public MovieServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Result>> GetPopularMovies()
        {
            return await _httpClient.GetFromJsonAsync<List<Result>>("PopularMovies");
        }

        public async Task<List<Result>> GetUpcomingMovies()
        {
            return await _httpClient.GetFromJsonAsync<List<Result>>("UpcomingMovies");
        }

        public async Task<MovieDetails> GetMovie()
        {
            return await _httpClient.GetFromJsonAsync<MovieDetails>("FindMovies");
        }
    }
}
