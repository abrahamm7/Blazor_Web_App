using Microsoft.AspNetCore.Http;
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
    public class PopularMoviesController : ControllerBase
    {
        public async Task<IActionResult> GetMovies()
        {
            try
            {
                var client = new RestClient(Constants.Requests.baseUrl);
                var request = new RestRequest(Constants.Requests.popularUrl, Method.GET);
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
