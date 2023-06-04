using System;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class NewMovie : Form
    {
        public string Name { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public string Genre { get; private set; }
        public string Synopsis { get; private set; }
        public double Rating { get; private set; }

        public NewMovie()
        {
            InitializeComponent();
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
            Rating= r;
            DialogResult = DialogResult.OK;
        }

        public Movie GetMovie()
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
