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
    public partial class EditMovie : Form
    {
        public string Name { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public string Genre { get; private set; }
        public string Synopsis { get; private set; }
        public double Rating { get; private set; }
        public EditMovie(Movie selectedMovie)
        {
            InitializeComponent();
            displayInfo(selectedMovie);
        }

        public void displayInfo(Movie movie)
        {
            Nametb.AppendText(movie.Name);
            ReleaseDatedtp.Value = movie.ReleaseDate;
            Genretb.AppendText(movie.Genre);
            Synopsistb.AppendText(movie.Synopsis);
            Ratingtb.AppendText(movie.Rating.ToString());
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            Name = Nametb.Text.Trim();
            ReleaseDate = ReleaseDatedtp.Value;
            Genre = Genretb.Text.Trim();
            Synopsis = Synopsistb.Text.Trim();
            double r = double.Parse(Ratingtb.Text.Trim());
            r = Math.Clamp(r, 0.0f, 10.0f);
            r = Math.Round(r, 2);
            Rating = r;
            DialogResult = DialogResult.OK;
        }

        public Movie updatedMovie()
        {
            return new Movie
            {
                Name = Name,
                ReleaseDate = ReleaseDate,
                Genre = Genre,
                Synopsis = Synopsis,
                Rating = Rating
            };
        }

    }
}
