using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace RestApiTester.Services.Concreate
{
    public static class LoggerService
    {
        private static readonly string FilePath = @$"{Environment.CurrentDirectory}\Logs\";

        public async static Task Write(string FileName, string Message)
        {
            string tempFileName = $"{FileName}" + DateTime.Now.ToString().Replace(".", "").Replace(":", "").Replace(" ", "");

            using (StreamWriter sw = new StreamWriter(FilePath + @$"{tempFileName}.txt", false, System.Text.Encoding.Default))
            {
                await sw.WriteLineAsync(Message);
            }
        }
    }
}
