using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMovie.Shared;

namespace WebMovie.Server.Services
{
    public interface IPopularMovieServices
    {
        Task<List<Result>> GetPopularMovies();
    }
}
