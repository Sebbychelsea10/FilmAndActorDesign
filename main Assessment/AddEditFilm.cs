using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_Assessment
{
    public partial class AddEditFilm : Form
    {
        public AddEditFilm(List<Film> films)
        {
            InitializeComponent();
            Films = films;
        }

        List<Film> Films;

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            Film filmToAdd = new Film(txtTitle.Text, txtActor.Lines.ToList(), txtDirector.Text);
            Films.Add(filmToAdd);
            string filmtext = "";
            filmtext += filmToAdd.GetTitle() + "|";

            for (int i = 0; i < filmToAdd.GetActors().Count; i++)
            {
                filmtext += filmToAdd.GetActors()[i];
                if (i == filmToAdd.GetActors().Count - 1)
                {
                    filmtext += "|";
                }
                else
                {
                    filmtext += ',';
                }



                File.AppendAllText("film_details.txt", filmtext);



                Close();
            }
        }
        
    }
}
