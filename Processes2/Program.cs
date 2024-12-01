// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//using System.Diagnostics;

namespace Processes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] allProcesses = Process.GetProcesses();
            for (int i = 0; i < allProcesses.Length; i++)
            {
                Console.WriteLine($"{allProcesses[i].Id}\t{allProcesses[i].ProcessName}"); ;
            }
        }

    }

}