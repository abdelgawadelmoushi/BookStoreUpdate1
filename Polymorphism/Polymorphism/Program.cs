using System;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual string AnimalSound()
    {
        return "The animal makes a sound";
    }
}

class Pig : Animal
{
    public int Size { get; set; }

    public Pig(string name, int age, int size) : base(name, age)
    {
        Size = size;
    }


    public override string AnimalSound()
    {
        return "The pig says: wee wee";
    }
}

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override string AnimalSound()
    {
        return "The dog says: bow wow";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal("Animal 1", 5);   
        Animal myPig = new Pig("Piggy", 3, 25);       
        Animal myDog = new Dog("Doggy", 4);           

        Console.WriteLine(myAnimal.AnimalSound()); 
        Console.WriteLine(myPig.AnimalSound());   
        Console.WriteLine(myDog.AnimalSound());    
    }
}
