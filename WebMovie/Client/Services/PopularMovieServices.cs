using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebMovie.Shared;

namespace WebMovie.Client.Services
{
    public class PopularMovieServices : IPopularMovieServices
    {
        readonly HttpClient _httpClient;

        public PopularMovieServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Result>> GetPopularMovies()
        {
            return await _httpClient.GetFromJsonAsync<List<Result>>("PopularMovies");
        }
    }
}
