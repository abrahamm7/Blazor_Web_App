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
    public class FindMoviesController : ControllerBase
    {
        public async Task<IActionResult> GetMovie(int id)
        {
            try
            {
                var client = new RestClient(Constants.Requests.baseUrl);
                var request = new RestRequest(Constants.Requests.findMovieUrl(id), Method.GET);
                var response = client.ExecuteAsync(request).Result.Content;
                var content = JsonConvert.DeserializeObject<MovieDetails>(response);
                return Ok(content);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
