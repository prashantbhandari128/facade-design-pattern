namespace FacadePattern.HomeTheater.Components
{
    internal class TV
    {
        public void On()
        {
            Console.WriteLine("TV is on.");
        }

        public void Off()
        {
            Console.WriteLine("TV is off.");
        }

        public void SetInputChannel()
        {
            Console.WriteLine("TV input channel set.");
        }
    }
}
