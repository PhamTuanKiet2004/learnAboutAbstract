using BaiTapTrenLop.Bai1;
using BaiTapTrenLop.Bai2;

Console.WriteLine("Bai 1");
Animal dog = new Dog();
dog.Eat();
dog.Sound();
Animal cat = new Cat();
cat.Eat();
cat.Sound();
Animal duck = new Duck();
duck.Eat();
duck.Sound();

Console.WriteLine("Bai 2");
Vehicle car = new Car();
car.Start();
car.Stop();
car.Move();
Vehicle bike = new Bike();
bike.Start();
bike.Move();
bike.Stop();
Vehicle boat =  new Boat();
boat.Start();
boat.Stop();
boat.Move();