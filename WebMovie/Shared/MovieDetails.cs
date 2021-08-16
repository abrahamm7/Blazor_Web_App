using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMovie.Shared
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductionCompany
    {
        public int Id { get; set; }
        public string logo_path { get; set; }
        public string Name { get; set; }
        public string origin_country { get; set; }
    }

    public class ProductionCountry
    {
        public string Iso31661 { get; set; }
        public string Name { get; set; }
    }

    public class SpokenLanguage
    {
        public string EnglishName { get; set; }
        public string Iso6391 { get; set; }
        public string Name { get; set; }
    }

    public class MovieDetails
    {
        public bool Adult { get; set; }
        public string backdrop_path { get; set; }
        public object belongs_to_collection { get; set; }
        public int Budget { get; set; }
        public IList<Genre> Genres { get; set; }
        public string Homepage { get; set; }
        public int Id { get; set; }
        public string ImdbId { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public string poster_path { get; set; }
        public IList<ProductionCompany> production_companies { get; set; }
        public IList<ProductionCountry> production_countries { get; set; }
        public string ReleaseDate { get; set; }
        public int Revenue { get; set; }
        public int Runtime { get; set; }
        public IList<SpokenLanguage> spoken_languages { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
    }
}
