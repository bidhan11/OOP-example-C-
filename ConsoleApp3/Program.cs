//using ConsoleApp3;
//using System;
//namespace InheritanceLab
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Messages.Greet();
//            LabObject l1 = new LabObject(3,"ROBIN");
//            l1.name = "hema";
//            l1.ShowDetails();
//            LabObject l2 = new LabObject(1, "Arun");
//            l2.ShowDetails();
//            l2.SetID(10);
//            LabObject default1 = new LabObject();
//            default1.ShowDetails();
//        }
//    }
//    class LabObject
//    {
//        private int id;
//        public string name;
//        public LabObject()
//        {
//            this.id = 1;
//            this.name = "Test";
//        }
//        //constructor
//        public LabObject(int id,string name)
//        {
//            this.id = id;
//            this.name = name;   

//        }
//        public void ShowDetails()
//        {
//            Console.WriteLine("Name of student " + name + " ID " + id);
//        }
//        public void SetID(int id)
//        {
//            this.id = id;
//        }
//    }
//}