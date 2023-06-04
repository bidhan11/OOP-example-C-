//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//   class ParentClass
//    {
//        public string name;
//        public int Id = 9;
//        public void displayParentClassDetails()
//        {
//            Console.WriteLine($"I am {name}");
//            Console.WriteLine($"I am {Id}");
//        }
//    }
//    class ChildClass : ParentClass {
//        public void getIdFromParentClass()
//        {
//            Console.WriteLine("Displaying from my child class");
//            Console.WriteLine($"This is my ID: {Id}");
//        }

//    }
//    class AnotherClass : ParentClass {
//        public void getIdFromParentClass() {
//            Console.WriteLine("Displaying from my child class");
//            Console.WriteLine($"This is my ID: {Id}");
//      }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ChildClass c1=new ChildClass();
//            AnotherClass c2=new AnotherClass();
//            c1.getIdFromParentClass();
//            c2.getIdFromParentClass();
//        }
//    }


//}
