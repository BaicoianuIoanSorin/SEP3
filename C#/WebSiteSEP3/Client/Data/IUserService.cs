﻿using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public interface IUserService
    {
        Task<User> ValidateLogin(string username, string password);
        
        // Task<User> RegisterUserAsync(string Username, string Password, string FirstName, string LastName);
        //
        Task RegisterUserAsync(User user);
    }
}