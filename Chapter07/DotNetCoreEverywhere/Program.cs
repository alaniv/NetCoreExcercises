using static System.Console;

/*
dotnet publish -c Release -r win10-x64
dotnet publish -c Release -r osx-x64
dotnet publish -c Release -r rhel.7.4-x64
*/

namespace DotNetCoreEverywhere
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("I can run everywhere!");
        }
    }
}
