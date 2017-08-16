using System;
using System.IO;
using System.Text;

namespace Plataforma.Infrastructure.WindowService.Service.Services
{
    public class UtilService
    {
        public static void Log(string description, string path)
        {
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                var pathFile = Path.Combine(path, DateTime.Now.ToString("yyyyMMdd") + ".txt");

                if (File.Exists(pathFile))
                {
                    var read = new StreamReader(pathFile, Encoding.GetEncoding("ISO-8859-1"));
                    description = $"{description}\n{read.ReadToEnd()}";
                    read.Close();
                }
                using (var output = new StreamWriter(pathFile, false, Encoding.GetEncoding("ISO-8859-1")))
                {
                    output.Write(description);
                }
            }
            catch (Exception)
            {
                GC.Collect();
            }
        }

        internal static void Log(string v, object p)
        {
            throw new NotImplementedException();
        }
    }
}
