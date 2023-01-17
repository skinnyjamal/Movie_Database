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
    public partial class NewMovie : Form
    {
        public string name;
        public string releaseDate;
        public string genre;
        public bool submit;
        public NewMovie()
        {
            InitializeComponent();
            submit = false;
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            Nametb.Text = name;
            string date = ReleaseDatedtp.Value.ToString("dd/MM/yyyy");
            date = releaseDate;
            Genretb.Text = genre;
            submit = true;
            
        }
    }
}
