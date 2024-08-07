using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDo_APIv1.Database;
using ToDo_APIv1.Models;

namespace ToDo_APIv1.Controllers
{
    [ApiController,Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        public UsersController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            if (!_dbContext.Users.Any()) 
            {
                _dbContext.Users.Add(new Users { Name="Антон", Age=24, Email="AHTOH228@outlook.com" });
                _dbContext.Users.Add(new Users { Name = "Алёна", Age = 23, Email = "prettygirlslime666@mail.ru" });
                _dbContext.SaveChanges();
            }
        }
        [HttpGet]
        public async Task<List<Users>> GetAllUsersAsync() 
        {
            return await _dbContext.Users.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetUserById(string id)
        {
            try
            {
                var user = await _dbContext.Users.SingleOrDefaultAsync(x => x.Id == Guid.Parse(id));
                if (user == null)
                    return NotFound("Такого пользователя нет");
                return Ok(user);
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult> AddUser(Users user)
        {
            try
            {
                if (user == null)
                    return BadRequest("user был null");
                await _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();
                return Ok(user);
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<ActionResult> UpdateUser(Users user) 
        {
            try
            {
                if (user == null)
                    return BadRequest("user был null");
                if (!await _dbContext.Users.AnyAsync(x=>x.Id == user.Id))
                    return NotFound("Такого пользователя нет");
                _dbContext.Users.Update(user);
                await _dbContext.SaveChangesAsync();
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(string id) 
        {
            try
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == Guid.Parse(id));
                if (user == null)
                {
                    return NotFound("Такой пользователь не найден");
                }
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
