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
        private List<Movie> movies;
        public static int selectedIndex;

        public MovieManager()
        {
            InitializeComponent();
            movies = LoadMovies() ?? new List<Movie>();
            RefreshMovieList();
        }

        private void Movielb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Movielb.SelectedIndex;
            if (index >= 0 && index < movies.Count)
            {
                Movie selectedMovie = movies[index];
                Namelbl.Text = selectedMovie.Name;
                Releaselbl.Text = selectedMovie.ReleaseDate.ToString("dd/MM/yyyy");
                Genrelbl.Text = selectedMovie.Genre;
                Synopsislbl.Text = selectedMovie.Synopsis;
                selectedIndex = index;
            }
            else
            {
                defualtView();
            }
            RefreshMovieList();
        }
        public void defualtView()
        {
            Namelbl.Text = "------";
            Releaselbl.Text = "------";
            Genrelbl.Text = "------";
            Synopsislbl.Text = "";
        }

        private void newMoviebtn_Click(object sender, EventArgs e)
        {
            NewMovie newMovie = new NewMovie();
            if (newMovie.ShowDialog() == DialogResult.OK)
            {
                Movie movie = newMovie.GetMovie();
                movies.Add(movie);
                SaveMovies();
                RefreshMovieList();
            }
        }

        private void SaveMovies()
        {
            string json = JsonSerializer.Serialize(movies, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        private List<Movie> LoadMovies()
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

        private void RefreshMovieList()
        {
            Movielb.Items.Clear();
            if (movies != null)
            {
                foreach (Movie movie in movies)
                {
                    Movielb.Items.Add(movie.Name);
                }
            }
        }

        private void delMoviebtn_Click(object sender, EventArgs e)
        {
            movies.Remove(movies[selectedIndex]);
            defualtView();
            SaveMovies();
            RefreshMovieList();
        }
    }
}