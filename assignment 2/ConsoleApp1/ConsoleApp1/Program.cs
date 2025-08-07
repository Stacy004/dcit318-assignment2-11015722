// See https://aka.ms/new-console-template for more information
using System;

namespace Assignmet2
{
    public class Animal 
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }


    public class Dog : Animal 
    {
       public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }


    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();    


            Console.WriteLine("Animal sound:");
            myAnimal.MakeSound();

            Console.WriteLine("\nDog sound:");
            dog.MakeSound();

            Console.WriteLine("\nCat sound:");
            cat.MakeSound();
        }
    }


}



