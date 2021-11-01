using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PuzzlesoftApi.Auth;
using PuzzlesoftApi.Model;
using Task = System.Threading.Tasks.Task;

namespace PuzzlesoftApi.Services
{
    public class TotlService : ITotlService
    {
        private Dictionary<string, string> TotlVault = new Dictionary<string, string>();

        public string CreateTotl(string id)
        {
            char[] codeArr = new char[6];
            var rand = new RNGCryptoServiceProvider();
            var s = "1234567890";
            for (int i = 0; i < codeArr.Length; i++)
            {
                byte[] b = new byte[1];
                rand.GetBytes(b);
                codeArr[i] = s[b[0] % s.Length];
            }
            var code = new string(codeArr);
            TotlVault[id] = code;
            Task.Run(() =>
            {
                Thread.Sleep(300000);
                TotlVault.Remove(id);
            });
            return code;
        }

        public bool CheckTotl(string id, string code)
        {
            return TotlVault.ContainsKey(id) && TotlVault[id] == code;
        }
    }
}