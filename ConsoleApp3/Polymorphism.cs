using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("This animal makes a sound");
        }
    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("This pig says: wee weee");
        }
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("This pig says: vauu vauu");
        }
    }
    class Polymorphism
    {
        static void Main(string[] args) { 
            Animal myAnimal=new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();

            myAnimal.animalSound(); 
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}
