using ConsoleApp1;

Animal animal = new Dog();
Console.WriteLine(animal.Sound);
animal.Move();
animal.FetchBall();

Dog dog = new Dog();
Console.WriteLine(dog.Sound);
dog.Move();
dog.FetchBall();

Cat cat = new Cat();
Console.WriteLine(cat.Sound);
cat.Move();
cat.ThrowOfTheTable();

(animal as IWalkable).Walk();
Dog dog1 = new Dog();
dog1.Walk();
IWalkable walkableDog = new Dog();
walkableDog.Walk();

Animal[]animals =  new Animal[] { new Cat(),new Dog(),new Salmon()};

foreach(Animal ani in animals)
{
    Console.WriteLine($"The {ani.GetType().Name} goes {ani.Sound}");
    animal.Move();
    if (ani is Mammal)
        (ani as Mammal).ProduceMilk();
    if (ani is IWalkable)
        (ani as IWalkable).Walk();
    if (ani is ISwimmable)
        (ani is Cat).Swim();





}