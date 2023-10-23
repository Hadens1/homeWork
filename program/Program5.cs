using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface ISpeak
{
    void Speak();
}

class Animal
{
    protected internal string Name; 
      
    public Animal(string name)
    {
        Name = name;
    }

      public virtual void Eat()
    {
        Console.WriteLine($"{Name} ест.");
    }
}

class Dog : Animal, ISpeak
{
     public Dog(string name) : base(name)
    {
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} собака лает.");
    }
       
    public void Speak()
    {
        Console.WriteLine($"{Name} собака говорит: Гав-гав!");
    }
      
    public override void Eat()
    {
        Console.WriteLine($"{Name} собака кушает косточку.");
    }
        
    public static Dog operator +(Dog dog1, Dog dog2)
    {
        return new Dog($"{dog1.Name} и {dog2.Name}");
    }

       public static Dog operator -(Dog dog1, Dog dog2)
    {
        Console.WriteLine($"{dog1.Name} и {dog2.Name} собаки не вычитаются.");
        return dog1;
    }
}

class Cat : Animal, ISpeak
{
        public Cat(string name) : base(name)
    {
    }
       
    public void Meow()
    {
        Console.WriteLine($"{Name} кошка мяукает.");
    }
       
    public void Speak()
    {
        Console.WriteLine($"{Name} кошка говорит: Мяу-мяу!");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} кошка кушает рыбку.");
    }
        
    public static Cat operator +(Cat cat1, Cat cat2)
    {
        return new Cat($"{cat1.Name} и {cat2.Name}");
    }

    public static Cat operator -(Cat cat1, Cat cat2)
    {
        Console.WriteLine($"{cat1.Name} и {cat2.Name} кошки не вычетаются.");
        return cat1;
    }
}

class Program
{
    static void Main()
    {
        Dog dog1 = new Dog("Никки");
        Dog dog2 = new Dog("Бакс");
        Cat cat1 = new Cat("Машка");
        Cat cat2 = new Cat("Мурка");
               
        Dog combinedDogs = dog1 + dog2;
        Cat combinedCats = cat1 + cat2;

        Console.WriteLine("Объединенные животные:");
        Console.WriteLine(combinedDogs.Name);
        Console.WriteLine(combinedCats.Name);
             
        Dog subtractionResult = dog1 - dog2;
        Cat subtractionResultCat = cat1 - cat2;
      
        dog1.Eat();
        cat1.Eat();

        dog1.Speak();
        cat1.Speak();

        dog1.Eat();
        cat1.Eat();

        dog1.Bark();
        dog2.Bark();
               
        cat1.Meow();
        cat2.Meow();

    }
}
