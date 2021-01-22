using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEAVUS.Movie.DataAccess.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(MovieDbContext context) : base(context) { }
        public User GetById(string id)
        {
            User user = _db.Users.SingleOrDefault(x => x.Id == id);
            return user;
        }

        public User GetByUsername(string username)
        {
            User user = _db.Users.SingleOrDefault(x => x.UserName == username);
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            // add include statemants
            IEnumerable<User> users = _db.Users;
            return users;
        }

        public int Insert(User entity)
        {
            _db.Users.Add(entity);
            return _db.SaveChanges();
        }

        public int Update(User entity)
        {
            _db.Users.Update(entity);
            return _db.SaveChanges();
        }

        public int Delete(string id)
        {
            User user = _db.Users.SingleOrDefault(x => x.Id == id);

            if (user == null)
                return -1;
            _db.Users.Remove(user);
            return _db.SaveChanges();
        }
    }
}
