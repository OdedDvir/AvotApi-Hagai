using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Converters;
using PuzzlesoftApi.Model;

namespace PuzzlesoftApi
{
    public static class Helper
    {
        public static void ReturnError(string errorCode, string errorMessage)
        {
            throw new PuzzlesoftGlobalError()
            {
                Data = { {"error_code", errorCode}, {"error_message", errorMessage}}
            };
        }

        public static void ReturnError(ServerErrors error)
        {
            ReturnError(((int)error).ToString(), Errors.errors[error]);
        }
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

        public static void AddParameters(this IDbCommand command, object args, ClaimsPrincipal user=null)
        {
            if (args is IDictionary<string, object>)
            {
                var dict = args as Dictionary<string, object>;
                foreach (var o in dict)
                {
                    if (o.Value.GetType().IsArray)
                    {
                        var counter = 1;
                        foreach (var arrElement in (IEnumerable) o.Value)
                        {
                            var paramName = o.Key + (counter > 1 ? counter.ToString() : string.Empty);
                            counter++;
                            command.AddParameter(paramName, arrElement);
                        }
                    }
                    command.AddParameter(o.Key, o.Value);
                }
            }
            else
            {
                foreach (var property in args.GetType().GetProperties())
                {
                    if (property.PropertyType.IsArray)
                    {
                        var counter = 1;
                        foreach (var arrElement in (IEnumerable) property.GetValue(args))
                        {
                            var paramName = property.Name + (counter > 1 ? counter.ToString() : string.Empty);
                            counter++;
                            command.AddParameter(paramName, arrElement);
                        }

                        continue;
                    }

                    if (property.GetCustomAttribute(typeof(UserIdAttribute)) == null)
                        command.AddParameter(property.Name, property.GetValue(args));
                    else
                        command.AddParameter(property.Name, user?.FindFirstValue(ClaimTypes.NameIdentifier));
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
        public static async Task<string> SendSms(string phoneNumber, string body)
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
    public class PuzzlesoftGlobalError : Exception {}

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class UserIdAttribute : Attribute {}
}