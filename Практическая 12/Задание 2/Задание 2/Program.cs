using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public static class ProgramConfig
    {
        private const string Version = "1.0";
        private const string DeveloperName = "Семенов Максим";

        public static void DisplayInfo()
        {
            Console.WriteLine($"Версия программы: {Version}");
            Console.WriteLine($"Разработчик: {DeveloperName}");
        }
    }
    class Program
    {
        static void Main()
        {
            ProgramConfig.DisplayInfo();
        }
    }
}
