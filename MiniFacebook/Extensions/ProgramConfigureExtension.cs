using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using System.Collections.ObjectModel;
using System.Data;

namespace MiniFacebook.API.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public class ProgramConfigureExtension
    {
        /// <summary>
        /// 
        /// </summary>
        public ProgramConfigureExtension()
        {
            var Configuration = new ConfigurationBuilder()
                       .AddJsonFile("appsettings.json")
                       .Build();
            Log.Logger = new LoggerConfiguration()
                             .ReadFrom.Configuration(Configuration)
                             .MinimumLevel.Error()
                             .WriteTo.MSSqlServer(Configuration["ConnectionStrings:FacebookDatabase"], "Logs", autoCreateSqlTable: true, columnOptions: GetSqlColumnOptions())
                             .CreateLogger();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ColumnOptions GetSqlColumnOptions()
        {
            var colOptions = new ColumnOptions();
            colOptions.Store.Remove(StandardColumn.Properties);
            colOptions.Store.Remove(StandardColumn.MessageTemplate);
            colOptions.Store.Remove(StandardColumn.Message);
            colOptions.Store.Remove(StandardColumn.Exception);
            colOptions.Store.Remove(StandardColumn.Level);

            colOptions.AdditionalDataColumns = new Collection<DataColumn>
            {
                new DataColumn {DataType = typeof(string), ColumnName = "Message"},
                new DataColumn {DataType = typeof(string), ColumnName = "StackTrace"},
                new DataColumn {DataType = typeof(string), ColumnName = "InnerException"},
                new DataColumn {DataType = typeof(string), ColumnName = "ErrorId"},
                new DataColumn {DataType = typeof(string), ColumnName = "ExceptionType"},
            };
            return colOptions;
        }
      
    }
}
