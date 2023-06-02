using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace MovieManager
{
    public partial class MovieManager : Form
    {
        private const string FilePath = "movies.json";
        List<Movie> movies = new List<Movie>();
        public MovieManager()
        {
            InitializeComponent();
            movies = LoadMovies();
        }

        private void Movielb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Movielb.SelectedIndex;
            Namelbl.Text = movies[index].Name;
            Releaselbl.Text = movies[index].ReleaseDate.ToString("DD/M/YYYY");
            Genrelbl.Text = movies[index].Genre;
        }

        private void newMoviebtn_Click(object sender, EventArgs e)
        {
            NewMovie newMovie = new NewMovie();
            newMovie.ShowDialog();

        }

        public void SaveMovies(List<Movie> movies)
        {
            string json = JsonSerializer.Serialize(movies, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public List<Movie> LoadMovies()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Movie>>(json);
            }
            else
            {
                return new List<Movie>();
            }
        }

    }
}
