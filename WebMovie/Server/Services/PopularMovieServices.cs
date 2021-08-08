using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMovie.Shared;

namespace WebMovie.Server.Services
{
    public class PopularMovieServices: IPopularMovieServices
    {
        public Task<List<Result>> GetPopularMovies()
        {
            try
            {
                var client = new RestClient(Constants.Requests.baseUrl);
                var request = new RestRequest(Constants.Requests.popularUrl, Method.GET);
                var response = client.ExecuteAsync(request).Result.Content;
                var content = JsonConvert.DeserializeObject<Movies>(response);
                return Task.FromResult(content.results);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
