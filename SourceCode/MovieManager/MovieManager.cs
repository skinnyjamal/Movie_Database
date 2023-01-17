using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class MovieManager : Form
    {
        List<Movie> movies = new List<Movie>();
        public MovieManager()
        {
            InitializeComponent();
            movies.Add(new Movie("Matrix", "11/6/1999", "Action, SciFi, Adventure, Fantasy"));
            movies.Add(new Movie("Creed", "15/1/2016", "Action, Drama, Sport"));
            movies.Add(new Movie("Rocky", "1/1/1977", "Action, Drama, Sport, Romance"));

            foreach (Movie M in movies)
            {
                Movielb.Items.Add(M.name);
            }
        }

        private void Movielb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Movielb.SelectedIndex;
            string name = movies[index].name;
            string releaseDate = movies[index].releaseDate;
            string genre = movies[index].name;

            Namelbl.Text = name;
            Releaselbl.Text = releaseDate;
            Genrelbl.Text = genre;
        }

        private void newMoviebtn_Click(object sender, EventArgs e)
        {
            NewMovie newMovie = new NewMovie();
            newMovie.ShowDialog();

            if (newMovie.submit == true)
            {
                movies.Add(new Movie(newMovie.name, newMovie.releaseDate, newMovie.genre));
            }
        }
    }
}
