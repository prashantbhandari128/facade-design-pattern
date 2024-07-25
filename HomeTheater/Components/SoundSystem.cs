namespace FacadePattern.HomeTheater.Components
{
    internal class SoundSystem
    {
        public void On()
        {
            Console.WriteLine("Sound System is on.");
        }

        public void Off()
        {
            Console.WriteLine("Sound System is off.");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"Sound System volume set to {level}.");
        }
    }
}
