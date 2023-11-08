using Session3OOP.Abstraction;
using Session3OOP.Interface;
using Session3OOP.Override;
using Session3OOP.Override.OverrideWithExample2;
using System;
using System.Runtime.ConstrainedExecution;

namespace Session3OOP
{


    internal class Program
    {//Polymorphism => Override (Inhertance)

        //public static void VehicleType(Vehicle vehicle)
        //{
        //    vehicle.StartEngine();
        //    vehicle.DisplayInfo();
        //}

        public static void Calculateshape(IShape shape)
        {
            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(shape.CalculatePerimeter());

        }//Circle // Rectangle 
       
        static void Main(string[] args)
        {
            //Dog dog = new Dog();

            //dog.MakeSound();    

            //Cat cat = new Cat();

            //cat.MakeSound();

            //Car car = new Car();    

            //car.StartEngine();
            //car.DisplayInfo();

            /// Binding: Reference Base (Parent) refer Object Child -> Inhertance -> is a
            /// Dog is a Animal
            /// Compiler => run function based on Object Type (virtual |override)
            //Animal animal = new Dog();

            //animal.MakeSound(); 

            //Vehicle vehicle = new BMW();

            //vehicle.StartEngine();

            //Car car = new Car();
            //Car motorCycle = new Car();
            //VehicleType(motorCycle);

            //-----------------------------------------------

            //Product product = new Product();    
            //Book book = new Book("Football", 500, "Ahmed Nasser");

            //Console.WriteLine(book.DisplayInfo());
            ////
            //Laptop laptop = new Laptop("Insipron 350",10000,"Dell");

            //Console.WriteLine(laptop.DisplayInfo());

            //Circle C1 = new Circle(5);

            //double Area = C1.CalculateArea();
            //Console.WriteLine(Area);

            //// Can't Create Object From Interface 
            //IShape shape = new Circle(5);

            //shape.Test();

            Rectangle rectangle = new Rectangle(10, 20);
            //double Pram = rectangle.CalculatePerimeter();

            Calculateshape(rectangle);

        }
    }
}
