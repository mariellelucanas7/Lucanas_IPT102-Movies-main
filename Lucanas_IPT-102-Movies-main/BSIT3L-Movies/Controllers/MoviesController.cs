using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
               new MovieViewModel {WatchMovie = "https://www.youtube.com/watch?v=lTaM8iCDSoU&list=PLoHqLbrS6SwA-y1Py71xgfjKl0fPzVfFi", Id = 1, Name = "Doctors", Rating = "5", ReleaseYear = 2018, Genre = "K-Drama" },
            new MovieViewModel {WatchMovie =  "https://www.youtube.com/watch?v=oNYxT-BL_Nw",Id = 2, Name = "Alvin and the Chipmunks", Rating = "4", ReleaseYear = 2017, Genre = "Fiction" },
            new MovieViewModel {WatchMovie =  "https://www.youtube.com/watch?v=5TI_X63bsmg",Id = 3, Name = "Coco", Rating = "5", ReleaseYear = 2023, Genre = "Fantasy/Fiction" },
            new MovieViewModel {WatchMovie =  "https://www.youtube.com/watch?v=m4Zevk9Fqhc",Id = 4, Name = "Super Detention", Rating = "4", ReleaseYear = 2019, Genre = "Fiction/Action" },
            new MovieViewModel {WatchMovie =  "https://www.youtube.com/watch?v=Rs_EOuASgFE",Id = 5, Name = "Spiderman", Rating = "5", ReleaseYear = 2022, Genre = "Drama/Action" },
            new MovieViewModel {WatchMovie =  "https://www.youtube.com/watch?v=Xg3_IE2q8p0",Id = 6, Name = "The Lost Medallion", Rating = "5", ReleaseYear = 2021, Genre = "Fiction/Action" },
            new MovieViewModel {WatchMovie =  "https://www.youtube.com/watch?v=NN6frQBdLUs",Id = 7, Name = "Forest Fairies", Rating = "4", ReleaseYear = 2018, Genre = "K-Drama" },
            new MovieViewModel {WatchMovie =  "https://www.youtube.com/watch?v=lyxtp2qzBAM",Id = 8, Name = "Restart the Earth", Rating = "5", ReleaseYear = 2017, Genre = "K-Drama" },
            new MovieViewModel {WatchMovie =  "https://www.youtube.com/watch?v=ySgDn66Mf1E",Id = 9, Name = "The Good Witch", Rating = "5", ReleaseYear = 2023, Genre = "K-Drama" },
            new MovieViewModel {WatchMovie =  "https://www.youtube.com/watch?v=v9uT8aFhsbk",Id = 10, Name = "Leap", Rating = "5", ReleaseYear = 2022, Genre = "Fiction/Fantasy" },
            new MovieViewModel {WatchMovie =  "https://www.youtube.com/watch?v=7aJFdSfCEGY",Id = 11, Name = "The Shrunken City", Rating = "4", ReleaseYear = 2020, Genre = "Action/Thriller" },
            new MovieViewModel {WatchMovie =  "https://www.youtube.com/watch?v=sWfgTiJ3sCs",Id = 12, Name = "The Secret Garden", Rating = "4", ReleaseYear = 2021, Genre = "Action/Thriller" },
            new MovieViewModel {WatchMovie = "https://www.youtube.com/watch?v=QUUPEFWfBEU&t=982s",Id = 13, Name = "The Mysterious Note", Rating = "4", ReleaseYear = 2023, Genre = "Drama/Action" },
            new MovieViewModel {WatchMovie =  "https://www.youtube.com/watch?v=cgq4p5kAl4k",Id = 14, Name = "Charmers", Rating = "5", ReleaseYear = 2020, Genre = "Drama/Action" },
            new MovieViewModel {WatchMovie = "https://www.youtube.com/watch?v=k32H2H3visE&list=PLVewHiZp3_LPfabGGMCvU8v137bdLIa-w",Id = 15, Name = "Charmers 2", Rating = "5", ReleaseYear = 2022, Genre = "Fiction/Action" },
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

