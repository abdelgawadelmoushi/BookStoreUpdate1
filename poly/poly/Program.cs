using System.Net.NetworkInformation;

namespace poly
{



    public class Animal
    {


        public string Name { get; set; }
        public double Age { get; set; }


        public Animal(string name, double age)

        {
            this.Name = name;
            this.Age = age;
        }

        public virtual string AnimalMakeSound() => "The Animal makes sound";



    }






    public class Pig : Animal
    {
        public double Size { get; set; }

        public Pig(string name, double age, double size)
               : base(name, age)
        {
            this.Size = size;
        }
        public override string AnimalMakeSound() => "The Pig says wee wee ";

    }

    public class Dog : Animal
        {

        public Dog (string name , double age ) : base (name , age)
        {


        }

        public override string AnimalMakeSound() => "The Dog Says bow bow";
     

        }
internal class Program
    {




        static void Main(string[] args)
        {
            Animal animal = new Animal("Animal 1 ", 5);

            Animal pig = new Pig("Animal 1 ", 5, 3);
            Animal dog = new Dog("Animal 2 ", 5);


            Console.WriteLine($"{animal} : {animal.AnimalMakeSound()}");
            Console.WriteLine( $"{pig.Name} :  {pig.AnimalMakeSound()} ");
            Console.WriteLine( $"{dog.Name} :  {dog.AnimalMakeSound()} ");

        }
    }
}
