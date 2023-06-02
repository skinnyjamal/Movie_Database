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

        public NewMovie()
        {
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            Name = Nametb.Text;
            ReleaseDate = ReleaseDatedtp.Value;
            Genre = Genretb.Text;
            Synopsis = Synopsistb.Text;
            DialogResult = DialogResult.OK;
        }

        public Movie GetMovie()
        {
            return new Movie
            {
                Name = Name,
                ReleaseDate = ReleaseDate,
                Genre = Genre,
                Synopsis = Synopsis
            };
        }
    }
}
