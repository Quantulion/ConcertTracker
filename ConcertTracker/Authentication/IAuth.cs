using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConcertTracker.ViewModels;

namespace ConcertTracker.Authentication
{
    public interface IAuth
    {
        Task<User> Register(RegisterViewModel model);
    }
}
