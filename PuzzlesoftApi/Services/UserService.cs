using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PuzzlesoftApi.Auth;
using PuzzlesoftApi.Model;

namespace PuzzlesoftApi.Services
{
    public class UserService : IUserService
    {
        private readonly dbcompdemoContext _context;

        public UserService(dbcompdemoContext context)
        {
            _context = context;
        }
        public ClientDetail GetUserByCredentials(string username, string password)
        {
            return _context.ClientDetails.FirstOrDefault(u =>
                u.WorkerUserName == username &&
                u.Password == password);;
        }
        public ClientDetail GetUserByCredentials(UserCredentials cred)
        {
            return _context.ClientDetails.FirstOrDefault(u =>
                u.WorkerUserName == cred.Username &&
                u.Password == cred.Password);
        }

        public ClientDetail GetUserById(int id)
        {
            return _context.ClientDetails.Find(id);
        }

        public IEnumerable<ClientDetail> GetAllUsers()
        {
            return _context.ClientDetails.ToArray();
        }
        public Task<ClientDetail> GetUserByCredentialsAsync(string username, string password)
        {
            return _context.ClientDetails.FirstOrDefaultAsync(u =>
                u.WorkerUserName == username &&
                u.Password == password);;
        }
        public Task<ClientDetail> GetUserByCredentialsAsync(UserCredentials cred)
        {
            return _context.ClientDetails.FirstOrDefaultAsync(u =>
                u.WorkerUserName == cred.Username &&
                u.Password == cred.Password);
        }

        public ValueTask<ClientDetail> GetUserByIdAsync(int id)
        {
            return _context.ClientDetails.FindAsync(id);
        }

        public Task<ClientDetail[]> GetAllUsersAsync()
        {
            return _context.ClientDetails.ToArrayAsync();
        }
    }
}