using System.Reflection;
using System.Runtime.CompilerServices;

namespace main_Assessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getfilms();

        }

        List<Film> films = new List<Film>();

        private void btnAddFilms(object sender, EventArgs e)
        {
            AddEditFilm addEditFilm = new AddEditFilm(films);
            addEditFilm.ShowDialog();
            refreshFilms();

        }

        private void btnDeleteClick(object sender, EventArgs e)
        {
            int index = lblFilms.SelectedIndex;
            lblFilms.Items.RemoveAt(index);
        }

        private void getfilms()
        {
            List<string> filmText = File.ReadAllLines("film_details.txt").ToList();

            foreach (var film in filmText)
            {
                List<string> filmDetails = film.Split('|').ToList();

                List<string> actors = filmDetails[1].Split(',').ToList();

                var filmToAdd = new Film(filmDetails[0], actors, filmDetails[2]);
                films.Add(filmToAdd);
            }
            refreshFilms();
        }
        void refreshFilms()
        {
            lblFilms.Items.Clear();
            foreach (var film in films)
            {
                lblFilms.Items.Add(film.GetTitle());
            }
        }

        private void lblFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshActors();
        }
        void refreshActors()
        {
            lblActors.Items.Clear();
            foreach (var film in films)
            {
                if (lblFilms.SelectedItem == film.GetTitle())
                {
                    foreach (var actor in film.GetActors())
                    {
                        lblActors.Items.Add(actor);
                    }

                }
            }
        }
    }
}