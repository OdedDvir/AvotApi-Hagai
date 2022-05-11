using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ElmahCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using PuzzlesoftApi.Model;
using Swashbuckle.AspNetCore.SwaggerGen;
using Task = PuzzlesoftApi.Model.Task;

namespace PuzzlesoftApi
{
    public static class Helper
    {
        public static PuzzleResponse<T> ReturnError<T>(string errorCode, string errorMessage)
        {
            return new PuzzleResponse<T>()
            {
                ErrorCode = errorCode,
                ErrorMessage = errorMessage
            };
        }

        private static List<T> _getDatasetTable<T>(this DataSet ds, int tableIndex = 0) where T : new()
        {
            if (ds.Tables.Count > tableIndex)
            {
                List<T> respTable = new List<T>();
                var table = ds.Tables[tableIndex];
                foreach (DataRow row in table.Rows)
                {
                    T t = new T();
                    foreach (var property in typeof(T).GetProperties())
                    {
                        try
                        {
                            property.SetValue(t, row[property.Name]);
                        }
                        catch (Exception) {}
                    }
                    respTable.Add(t);
                }

                return respTable;
            }

            return null;
        }
        public static PuzzleDataset<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ToResponse<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this DataSet ds) 
            where T1: new()
            where T2: new()
            where T3: new() 
            where T4: new() 
            where T5: new() 
            where T6: new() 
            where T7: new() 
            where T8: new() 
            where T9: new() 
            where T10: new()
            where T11: new()
        {
            int tableCounter = 0;
            var puzzleDataset = new PuzzleDataset<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            {
                Table = ds._getDatasetTable<T1>(tableCounter++),
                Table1 = ds._getDatasetTable<T2>(tableCounter++),
                Table2 = ds._getDatasetTable<T3>(tableCounter++),
                Table3 = ds._getDatasetTable<T4>(tableCounter++),
                Table4 = ds._getDatasetTable<T5>(tableCounter++),
                Table5 = ds._getDatasetTable<T6>(tableCounter++),
                Table6 = ds._getDatasetTable<T7>(tableCounter++),
                Table7 = ds._getDatasetTable<T8>(tableCounter++),
                Table8 = ds._getDatasetTable<T9>(tableCounter++),
                Table9 = ds._getDatasetTable<T10>(tableCounter++),
                Table10 = ds._getDatasetTable<T11>(tableCounter)
            };
            return puzzleDataset;
        }
        public static List<T> ToResponse<T>(
            this DataSet ds) 
            where T: new()
        {
            return ds._getDatasetTable<T>();
        }
        
        public static string ToResponse(
            this DataSet ds)
        {
            if (ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0][0]?.ToString();
            
            return string.Empty;
        }

        public static PuzzleResponse<T> ReturnError<T>(ServerErrors error)
        {
            return ReturnError<T>(((int)error).ToString(), Errors.errors[error]);
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
                foreach (var property in args.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
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
            var resp = await client.PostAsync("https://019sms.co.il:8090/api", content);
            return await resp.Content.ReadAsStringAsync();
        }
    }
    public class PuzzlesoftGlobalError : Exception {}

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class UserIdAttribute : Attribute {}
    
    public class ElmahFilter : IErrorFilter
    {
        public void OnErrorModuleFiltering(object sender, ExceptionFilterEventArgs args)
        {
            if (args.Exception is PuzzlesoftGlobalError)
                args.Dismiss();
        }
    }

    public class SwaggerAuthFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var attributes = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
                .Union(context.MethodInfo.GetCustomAttributes(true))
                .OfType<AuthorizeAttribute>();

            if (attributes == null || attributes.Count() == 0)
                return;
            var attr = attributes.ToList()[0];

            IList<string> securityInfos = new List<string>();
            securityInfos.Add($"{nameof(AuthorizeAttribute.Policy)}:{attr.Policy}");
            securityInfos.Add($"{nameof(AuthorizeAttribute.Roles)}:{attr.Roles}");
            securityInfos.Add($"{nameof(AuthorizeAttribute.AuthenticationSchemes)}:{attr.AuthenticationSchemes}");
            
            operation.Security = new List<OpenApiSecurityRequirement>()
            {
                new OpenApiSecurityRequirement()
                {
                    {new OpenApiSecurityScheme()
                    {
                        Reference = new OpenApiReference()
                        {
                            Id = "Basic",
                            Type = ReferenceType.SecurityScheme
                        }
                    },securityInfos} 
                }
            };
            operation.Responses["401"] = new OpenApiResponse()
            {
                Description = "Unauthorized"
            };
        }
    }
}