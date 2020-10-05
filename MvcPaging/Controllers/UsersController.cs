using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcPaging.Models;

namespace MvcPaging.Controllers
{
    public class UsersController : Controller
    {
        private readonly List<User> _userList;

        public UsersController()
        {
            const int numberUsers = 100;
            _userList = CreateUserList(numberUsers);
        }

        public IActionResult Index()
        {
            return View("UserList", _userList);
        }

        private static List<User> CreateUserList(int numberUsers)
        {
            List<User> userList = new List<User>();

            for (int n = 1; n <= numberUsers; n++)
            {
                User user = new User
                {
                    UserId = n,
                    FirstName = $"FirstName{n}",
                    LastName = $"LastName{n}"
                };

                userList.Add(user);
            }

            return userList;
        }
    }
}
