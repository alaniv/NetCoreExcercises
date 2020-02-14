using static System.Console;
namespace Packt.Shared
{
    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop() // default impl c#8.
        {
            WriteLine("Default implementation of Stop.");
        }
    }
}