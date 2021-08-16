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
        public string LogoPath { get; set; }
        public string Name { get; set; }
        public string OriginCountry { get; set; }
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
        public string BackdropPath { get; set; }
        public object BelongsToCollection { get; set; }
        public int Budget { get; set; }
        public IList<Genre> Genres { get; set; }
        public string Homepage { get; set; }
        public int Id { get; set; }
        public string ImdbId { get; set; }
        public string OriginalLanguage { get; set; }
        public string OriginalTitle { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public string PosterPath { get; set; }
        public IList<ProductionCompany> ProductionCompanies { get; set; }
        public IList<ProductionCountry> ProductionCountries { get; set; }
        public string ReleaseDate { get; set; }
        public int Revenue { get; set; }
        public int Runtime { get; set; }
        public IList<SpokenLanguage> SpokenLanguages { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }
    }



}
