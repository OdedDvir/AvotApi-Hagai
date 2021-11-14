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
        private Dictionary<string, CancellationTokenSource> TotlExpTasks = new Dictionary<string, CancellationTokenSource>();

        public string CreateTotl(string id)
        {
            if (TotlExpTasks.Remove(id, out var ct))
            {
                ct.Cancel();
            }
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
            var ctSource = new CancellationTokenSource();
            Task.Run(() =>
            {
                Thread.Sleep(120000);
                if (!ctSource.Token.IsCancellationRequested)
                {
                    TotlExpTasks.Remove(id);
                    TotlVault.Remove(id);
                }
            }, ctSource.Token);
            TotlExpTasks[id] = ctSource;
            return code;
        }

        public bool CheckTotl(string id, string code)
        {
            if (TotlVault.ContainsKey(id) && TotlVault[id] == code)
            {
                TotlVault.Remove(id);
                return true;
            }

            Helper.ReturnError(ServerErrors.InvalidMfaCode);
            return false;
        }
    }
}