using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GoodCivilianshipAPI.Models;

namespace GoodCivilianshipAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix ("api")]
    public class UserController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("users")]
        public IEnumerable<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            User u1 = new User();
            u1.Name = "Luke Skywalker";
            u1.PhoneNumber = "6101231234";
            User u2 = new User();
            u2.Name = "Obi Wan Kenobi";
            u2.PhoneNumber = "4841231234";
            users.Add(u1);
            users.Add(u2);

            return users;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [Route("users/{userId}")]
        public User GetUser(string userId)
        {
            User u2 = new User();
            u2.Name = "Obi Wan Kenobi";
            u2.PhoneNumber = "4841231234";

            return u2;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        [HttpPost]
        [Route("users")]
        public void CreateUser ([FromBody] User user)
        {
            Console.WriteLine("user - " + user.Name);
        }
    }
}
