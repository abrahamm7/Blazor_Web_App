using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMovie.Server.Services;
using WebMovie.Shared;

namespace WebMovie.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PopularMoviesController : ControllerBase
    {
        readonly IPopularMovieServices _popularMovieServices;

        public PopularMoviesController(IPopularMovieServices popularMovieServices)
        {
            _popularMovieServices = popularMovieServices;
        }
        
        //public async Task<List<Result>> GetMovies()
        //{
        //    var movieList = _popularMovieServices.GetPopularMovies().Result;
        //    return movieList;
        //}

        public async Task<IActionResult> GetMovies()
        {
            var movieList = _popularMovieServices.GetPopularMovies().Result;
            return Ok(movieList);
        }
    }
}
