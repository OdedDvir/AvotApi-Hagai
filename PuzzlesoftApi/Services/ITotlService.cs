using System.Collections.Generic;
using System.Threading.Tasks;
using PuzzlesoftApi.Auth;
using PuzzlesoftApi.Model;

namespace PuzzlesoftApi.Services
{
    public interface ITotlService
    {
        string CreateTotl(string id);
        bool CheckTotl(string id, string code);
    }
}