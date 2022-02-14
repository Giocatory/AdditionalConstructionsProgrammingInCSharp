namespace LessonFive
{
    internal class Car
    {
        private int speed = 0;

        public delegate void ToFast();

        private ToFast? toFast;

        public void Start()
        {
            speed = 10;
            Console.WriteLine($"We begin drive! Speed - {speed}");
        }

        public void Accelerate()
        {
            speed += 20;
            Console.WriteLine($"Speed - {speed}");

            if (speed > 80)
            {
                toFast();
            }
        }

        public void Stop()
        {
            speed = 0;
            Console.WriteLine($"We stop! Speed - {speed}");
        }

        public void RegisterOnToFast(ToFast toFast) => this.toFast = toFast;
    }
}