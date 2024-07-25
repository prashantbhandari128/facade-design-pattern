using FacadePattern.HomeTheater.Components;
using FacadePattern.HomeTheater;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            SoundSystem soundSystem = new SoundSystem();
            DVDPlayer dvdPlayer = new DVDPlayer();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(tv, soundSystem, dvdPlayer);

            homeTheater.WatchMovie("The Matrix");
            Console.WriteLine();
            homeTheater.EndMovie();
        }
    }
}
