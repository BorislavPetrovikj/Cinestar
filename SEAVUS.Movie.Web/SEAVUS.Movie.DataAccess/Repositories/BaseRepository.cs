using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.DataAccess.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly MovieDbContext _db;
        public BaseRepository(MovieDbContext db)
        {
            _db = db;
        }
    }
}
