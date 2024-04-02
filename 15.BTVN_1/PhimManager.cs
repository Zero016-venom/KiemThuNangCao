using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BTVN_1
{
	public class PhimManager
	{
		public List<Phim> _movies;
        public PhimManager()
        {
            _movies = new List<Phim>();
        }

        public void AddMovie(Phim movie)
        {
            _movies.Add(movie);
        }

        public void DeleteMovie(int id)
        {
            _movies.RemoveAll(a => a.MovieId == id);
        }

        public void UpdateMovie(int id, string newTitle)
        {
            var temp = _movies.FirstOrDefault(a => a.MovieId == id);
            if (temp != null)
            {
                temp.Title = newTitle;
            }
        }

        public Phim FindByID(int id)
        {
            return _movies.Find(a => a.MovieId == id);
        }

    }
}
