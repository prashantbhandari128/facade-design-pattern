using FacadePattern.HomeTheater.Components;

namespace FacadePattern.HomeTheater
{
    internal class HomeTheaterFacade
    {
        private TV _tv;
        private SoundSystem _soundSystem;
        private DVDPlayer _dvdPlayer;

        public HomeTheaterFacade(TV tv, SoundSystem soundSystem, DVDPlayer dvdPlayer)
        {
            _tv = tv;
            _soundSystem = soundSystem;
            _dvdPlayer = dvdPlayer;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _tv.On();
            _tv.SetInputChannel();
            _soundSystem.On();
            _soundSystem.SetVolume(20);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _dvdPlayer.Off();
            _soundSystem.Off();
            _tv.Off();
        }
    }
}
