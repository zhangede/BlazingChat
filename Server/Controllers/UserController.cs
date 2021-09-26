using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlazingChat.Shared;
using BlazingChat.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingChat.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UserController> _logger;
        private BlazingChatContext _context;

        public UserController(
            ILogger<UserController> logger, 
            BlazingChatContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("getprofile/{userId}")]
        public async Task<User> GetProfile(int userId){
            return await _context.Users.Where(u=>u.UserId == userId).FirstOrDefaultAsync();
        }

        [HttpGet]
        public List<Contact> Get()
        {
            var users = _context.Users.ToList();



            List<Contact> contacts = new List<Contact>();

            foreach(var user in users){
                contacts.Add(new Contact(user.FirstName, user.LastName));
            }

            return contacts;

        }
    }
}
