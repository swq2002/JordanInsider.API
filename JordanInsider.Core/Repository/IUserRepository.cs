﻿using JordanInsider.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordanInsider.Core.Repository
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(decimal userId);
        void CreateUser(User userData);
        void UpdateUser(User userData);
        void DeleteUser(decimal userId);
    }
}
