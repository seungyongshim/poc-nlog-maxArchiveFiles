using System;
using System.Threading.Tasks;
using NLog;

namespace ConsoleApp1
{
    internal class Program
    {
        private static readonly ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        private static async Task Main(string[] args)
        {
            while (true)
            {
                Logger.Info("{i}");

                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }
}
