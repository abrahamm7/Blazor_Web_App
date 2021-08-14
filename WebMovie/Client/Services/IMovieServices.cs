using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMovie.Shared;

namespace WebMovie.Client.Services
{
    public interface IMovieServices
    {
        Task<List<Result>> GetPopularMovies();
        Task<List<Result>> GetUpcomingMovies();
    }
}
