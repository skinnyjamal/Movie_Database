using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager
{
    class Movie
    {
        public string name;
        public string releaseDate;
        public string genre;

        public Movie(string mName, string mReleaseDate, string mGenre)
        {
            name = mName;
            releaseDate = mReleaseDate;
            genre = mGenre;
        }

    }
}
