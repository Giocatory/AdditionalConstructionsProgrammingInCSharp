using LessonFive;

Car car = new();
car.Start();
car.RegisterOnToFast(HandleOnToFast);

car.Accelerate();
car.Accelerate();

MyDelegate myDelegate = car.Accelerate;
myDelegate += car.Accelerate;
myDelegate.Invoke();

void HandleOnToFast()
{
    Console.WriteLine("Very fast? stop!");
    car.Stop();
}

public delegate void MyDelegate();