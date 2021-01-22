using SEAVUS.Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        User GetByUsername(string username);
        User GetById(string id);
    }
}
