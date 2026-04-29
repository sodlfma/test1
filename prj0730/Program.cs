using System;
using System.IO;

namespace prj0730
{
    class Program
    {
        static void Main(string[] args)
        {
            var htmlFileName = "connection-environments.html";
            var outputPath = Path.Combine(AppContext.BaseDirectory, htmlFileName);
            var projectPath = Path.Combine(Directory.GetCurrentDirectory(), htmlFileName);

            Console.WriteLine("접속환경 관리 화면을 브라우저에서 열어 사용하세요.");
            Console.WriteLine(File.Exists(outputPath) ? outputPath : projectPath);
        }
    }
}
