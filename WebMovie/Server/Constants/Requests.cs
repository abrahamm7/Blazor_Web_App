using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMovie.Server.Constants
{
    public static class Requests
    {
        public static string baseUrl = "https://api.themoviedb.org";
        public static string popularUrl = "https://api.themoviedb.org/3/movie/popular?api_key=93677fcde6181c9d54d22f3161f5c998&language=en-US";
        public static string upcomingUrl = "https://api.themoviedb.org/3/movie/upcoming?api_key=93677fcde6181c9d54d22f3161f5c998&language=en-US";
    }
}
