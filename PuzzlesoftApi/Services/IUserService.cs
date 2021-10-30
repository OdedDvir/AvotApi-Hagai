using System.Collections.Generic;
using System.Threading.Tasks;
using PuzzlesoftApi.Auth;
using PuzzlesoftApi.Model;

namespace PuzzlesoftApi.Services
{
    public interface IUserService
    {
        ClientDetail GetUserByCredentials(string username, string password);
        ClientDetail GetUserByCredentials(UserCredentials cred);
        ClientDetail GetUserById(int id);
        IEnumerable<ClientDetail> GetAllUsers();
        Task<ClientDetail> GetUserByCredentialsAsync(string username, string password);
        Task<ClientDetail> GetUserByCredentialsAsync(UserCredentials cred);
        ValueTask<ClientDetail> GetUserByIdAsync(int id);
        Task<ClientDetail[]> GetAllUsersAsync();
    }
}