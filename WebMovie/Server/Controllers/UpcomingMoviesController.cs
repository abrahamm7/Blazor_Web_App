using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMovie.Shared;

namespace WebMovie.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpcomingMoviesController : Controller
    {
        public async Task<IActionResult> GetUpcomingMovies()
        {
            try
            {
                var client = new RestClient(Constants.Requests.baseUrl);
                var request = new RestRequest(Constants.Requests.upcomingUrl, Method.GET);
                var response = client.ExecuteAsync(request).Result.Content;
                var content = JsonConvert.DeserializeObject<Movies>(response);
                return Ok(content.results);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
