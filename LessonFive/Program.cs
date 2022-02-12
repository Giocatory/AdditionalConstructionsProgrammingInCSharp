using LessonFive;

Car car = new();
car.Start();
car.RegisterOnToFast(HandleOnToFast);

car.Accelerate();
car.Accelerate();
car.Accelerate();
car.Accelerate();

void HandleOnToFast()
{
    Console.WriteLine("Very fast? stop!");
    car.Stop();
}