using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Helper;
using TaskManagementSystem.Models;
using TaskManagementSystem.Repository;

namespace TaskManagementSystem.Services
{
    public class UserService
    {
        IRepository<User> _userRepo;
        public UserService(IRepository<User> userService)
        {
            _userRepo = userService;
        }

        public async Task RegisterAsync(User user)
        {
            await _userRepo.AddAsync(user);
            _userRepo.SaveChanges();

        }

        public bool login(string email, string password)
        {
            var User = _userRepo
                .GetAll(x => x.Email == email && x.Password == password)
                .FirstOrDefault();
            if (User is not null) 
            {
                UserSession.ID = User.ID;
                UserSession.Username = User.Name;
                return true;
            }
            else return false;
            
        }
    }
}
