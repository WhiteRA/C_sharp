using UserService.Data;
using UserService.Dtos;
using UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UserService.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public ServiceResult Register(UserDto userDto)
        {
            if (_context.Users.Any(u => u.Email == userDto.Email))
            {
                return new ServiceResult { Success = false, Message = "Email already exists" };
            }

            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = userDto.Email,
                Password = HashPassword(userDto.Password),
                Role = "User"
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return new ServiceResult { Success = true, Message = "User registered successfully" };
        }

        public ServiceResult Authenticate(UserDto userDto)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == userDto.Email);

            if (user == null || !VerifyPassword(userDto.Password, user.Password))
            {
                return new ServiceResult { Success = false, Message = "Email or password is incorrect" };
            }

            return new ServiceResult { Success = true, Message = "User authenticated successfully" };
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public ServiceResult Delete(Guid id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return new ServiceResult { Success = false, Message = "User not found" };
            }

            _context.Users.Remove(user);
            _context.SaveChanges();

            return new ServiceResult { Success = true, Message = "User deleted successfully" };
        }

        private string HashPassword(string password)
        {
            // Implement password hashing
            return password;
        }

        private bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            // Implement password verification
            return inputPassword == hashedPassword;
        }
    }
}

