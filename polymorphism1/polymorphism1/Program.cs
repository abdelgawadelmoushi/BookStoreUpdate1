using System;

namespace polymorphism1
{


    public class Animal
    {


        public string Name { get; set; }
        public int Age { get; set; }


        public Animal(string name, double age)

        {
            this.Name = name;
            this.Age = age;
        }

                    public virtual string AnimalMakeSound() => "The Animal makes sound"



        }






    public class Pig : Animal(string name, string age, double size) :base ( name,  age)
        {
                 public double Size { get; set; }

        public Pig(string name, int age, double size)
               : base(name, age)
        {
            this.Size = size;
        }
    public override string  AnimalMakeSount() => "The Pig says wee wee "

    }




}
internal class Program

        
    {



        static void Main(string[] args)
        {
        Animal animal = new Animal("Animal 1 ", 5);

        Animal pig = new Pig("Animal 1 ", 5, 3);


        Console.WriteLine($"{Animal} : {animal.AnimalMakeSound}");
        Console.WriteLine($ $"{pig.Name} :  {pig.AnimalMakeSound} ");

        }
    }
}
