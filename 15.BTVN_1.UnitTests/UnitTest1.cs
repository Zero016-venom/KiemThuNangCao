using System.Text.RegularExpressions;

namespace _15.BTVN_1.UnitTests
{
	[TestFixture]
	public class Tests
	{
		public Phim _movie;
		public PhimManager _movieManger;

		[SetUp]
		public void Setup()
		{
			_movieManger = new PhimManager();
		}

		[Test]
		public void Test_AddMovie()
		{
			_movie = new Phim(1, "Quật mộ trùng ma", "Kinh dị", 2024, "Jang Jae-hyun");
			_movie = new Phim(2, "Godzilla x Kong: Đế chế mới", "Khoa học viễn tưởng", 2024, "Adam Wingard");

			_movieManger.AddMovie(_movie);

			//_movieManger.AddMovie(new Phim(2, "Godzilla x Kong: Đế chế mới", "Khoa học viễn tưởng", 2024, "Adam Wingard"));

			Assert.Contains(_movie, _movieManger._movies);
		}

		[Test]
		public void Test_Title_NotContain_Special_Characters()
		{
			_movie = new Phim(1, "Quat mo trung ma", "Kinh dị", 2024, "Jang Jae-hyun");
			//_movie = new Phim(1, "Quật mộ trùng ma", "Kinh dị", 2024, "Jang Jae-hyun");

			if (Regex.IsMatch(_movie.Title, "^[a-zA-Z0-9\\s]+$"))
			{
				_movieManger.AddMovie(_movie);
			}

			Assert.IsTrue(_movieManger._movies.Contains(_movie));
		}

        [Test]
        public void Test_Title_Contain_Special_Characters()
        {
            //_movie = new Phim(1, "Quat mo trung ma", "Kinh dị", 2024, "Jang Jae-hyun");
            _movie = new Phim(1, "Quật mộ trùng ma", "Kinh dị", 2024, "Jang Jae-hyun");

            if (Regex.IsMatch(_movie.Title, "^[a-zA-Z0-9\\s]+$"))
            {
                _movieManger.AddMovie(_movie);
            }

            Assert.IsFalse(_movieManger._movies.Contains(_movie));
        }

        [Test]
		public void Test_FindMoive_ByID()
		{
			_movie = new Phim(1, "Quat mo trung ma", "Kinh dị", 2024, "Jang Jae-hyun");
			_movieManger.AddMovie(new Phim(2, "Godzilla x Kong: Đế chế mới", "Khoa học viễn tưởng", 2024, "Adam Wingard"));

			_movieManger.AddMovie(_movie);

			int movieId = 1;
			Phim foundMovie = _movieManger.FindByID(movieId);

			Assert.IsNotNull(foundMovie);
		}
	}
}