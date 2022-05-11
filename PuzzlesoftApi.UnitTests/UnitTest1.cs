using System;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PuzzlesoftApi.Model;
using PuzzlesoftApi.Services;
using Xunit;

namespace PuzzlesoftApi.UnitTests
{

    public class UnitTests
    {
        private readonly ITotlService _totlService = new TotlService();
        private readonly DbContext _context;
        private ClientDetail _cd = new ClientDetail
        {
            Account = "123",
            Appointments = { },
            Archive = false,
            Birthday = DateTime.Now.Subtract(TimeSpan.FromDays(365 * 25)),
            Childs = 0,
            City = "Tel Aviv",
            Comments = "none",
            Company = "Puzzlesoft",
            Details = "Some Details",
            Email = "wildhagai@puzzlesoft.co.il",
            Ext = "",
            Fax = "039999999",
            Fname = "Test",
            Gender = 2,
            Harshah = "",
            Hospital = "Test Hospital",
            Id = 2297,
            Idcard = "9988",
            Idnum = 2297,
            Interkum = 0,
            Lname = "Test",
            Phone1 = "0552603210"
        };
        private readonly Random _random = new Random();

        public UnitTests()
        {
            var builder = new DbContextOptionsBuilder<dbcompdemoContext>();
            builder.UseInMemoryDatabase("testDb");
            _context = new dbcompdemoContext(builder.Options);
        }
        [Fact]
        public void Totl_GeneratesValidCode()
        {
            var code = _totlService.CreateTotl(_cd.Id.ToString());
            Assert.Equal(6, code.Length);
            Assert.True(int.TryParse(code, out var res));
        }
        [Fact]
        private void Totl_CodeExpiresAfter2Minutes()
        {
            
            var id1 = _random.Next(100000).ToString();
            var id2 = _random.Next(100000).ToString();
            var code1 = _totlService.CreateTotl(id1);
            var code2 = _totlService.CreateTotl(id2);
            Thread.Sleep(119000);
            Assert.True(_totlService.CheckTotl(id1, code1));
            Thread.Sleep(1001);
            var ex = Assert.ThrowsAny<PuzzlesoftGlobalError>(() => _totlService.CheckTotl(id2, code2));
            Assert.Equal("300", ex.Data["error_code"]);
        }
    }
}