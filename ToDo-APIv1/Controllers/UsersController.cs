using Microsoft.AspNetCore.Mvc;
using ToDo_APIv1.Models;

namespace ToDo_APIv1.Controllers
{
    [ApiController,Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public void GetUserById(int id)
        {

        }
        [HttpPost]
        public void AddUser(UserModel user)
        {

        }
        [HttpPut]
        public void UpdateUser(UserModel user) 
        { 
        
        }
        [HttpDelete("{id}")]
        public void DeleteUser(int id) 
        { 
        
        }
    }
}
