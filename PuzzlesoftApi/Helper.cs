using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Converters;

namespace PuzzlesoftApi
{
    public static class Helper
    {
        public static Dictionary<string, List<Dictionary<string, object>>> ToDictionary(this DataSet ds)
        {
            var tables = new Dictionary<string, List<Dictionary<string, object>>>();
            var counter = 0;
            foreach (DataTable dataTable in ds.Tables)
            {
                var rowsList = new List<Dictionary<string, object>>();
                foreach (DataRow dataTableRow in dataTable.Rows)
                {
                    var row = new Dictionary<string, object>();
                    foreach (DataColumn dataTableColumn in dataTable.Columns)
                    {
                        row[dataTableColumn.ColumnName] = dataTableRow[dataTableColumn];
                    }
                    rowsList.Add(row);
                }
                var tableName = counter == 0 ? "Table" : "Table" + counter;
                counter++;
                tables[tableName] = rowsList;
            }

            return tables;
        }
        public static void AddParameter (this IDbCommand command, string name, object value)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            command.Parameters.Add(parameter);
        }

        public static void AddParameters(this IDbCommand command, object args)
        {
            foreach (var property in args.GetType().GetProperties())
            {
                command.AddParameter(property.Name, property.GetValue(args));
            }
        }

        public static Dictionary<string, List<Dictionary<string, object>>> ExecuteProc(this DbContext context, string proc,
            object args)
        {
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = proc;
                command.CommandType = CommandType.StoredProcedure;
                command.AddParameters(args);
                context.Database.OpenConnection();
             
                using (var adp = DbProviderFactories.GetFactory(command.Connection).CreateDataAdapter())
                {
                    adp.SelectCommand = command;
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    return ds.ToDictionary();
                }
            }
        }
        public static object ExecuteProcAndGetValue(this DbContext context, string proc,
            object args)
        {
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = proc;
                command.CommandType = CommandType.StoredProcedure;
                command.AddParameters(args);
                context.Database.OpenConnection();
             
                using (var adp = DbProviderFactories.GetFactory(command.Connection).CreateDataAdapter())
                {
                    adp.SelectCommand = command;
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    return ds.Tables[0].Rows[0][0];
                }
            }
        }

        public static string Coalesce(this string s, params string[] arr)
        {
            if (!string.IsNullOrWhiteSpace(s))
                return s;
            return arr.FirstOrDefault(a => !string.IsNullOrWhiteSpace(a));
        }
    }

    public static class SmsService
    {
        async public static Task<string> SendSms(string phoneNumber, string body)
        {
            var content = new StringContent($@"<?xml version=""1.0"" encoding=""UTF-8""?>
                <sms>
                <user>
                <username>IICDz5lO</username>
                <password>DOmyF6oR</password>
                </user>
                <source>puzzlesoft</source>
                <destinations>
                <phone>{phoneNumber}</phone>
                </destinations>
                <message>{body}</message>
                <add_dynamic>0</add_dynamic>
                </sms>", Encoding.UTF8, "text/xml")
            {
                Headers = { {"SOAPAction", "http://tempuri.org/Send"} }
            };
            var client = new HttpClient();
            var resp = await client.PostAsync("https://www.019sms.co.il:8090/api", content);
            return await resp.Content.ReadAsStringAsync();
        }
    }
}