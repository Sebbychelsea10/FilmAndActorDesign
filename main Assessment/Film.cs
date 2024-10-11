using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace main_Assessment
{
    public class Film
    {
        public Film(string title, List<string> actors, string director)
        {
            Title = title;
            Actors = actors;
            Director = director;
        }

        private string Title;
        private List<string> Actors;
        private string Director;

        public string GetTitle()
        {
            return Title;
        }

        public List<string> GetActors() 
        {
            return Actors;
        }
    }
}
