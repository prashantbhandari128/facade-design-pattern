namespace FacadePattern.HomeTheater.Components
{
    internal class DVDPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD Player is on.");
        }

        public void Off()
        {
            Console.WriteLine("DVD Player is off.");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"Playing \"{movie}\".");
        }
    }
}
