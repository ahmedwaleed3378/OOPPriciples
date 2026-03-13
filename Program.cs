using OOPPriciples.Advanced;
using OOPPriciples.Principles.Abstraction;
using OOPPriciples.Principles.Encapsulation;
using OOPPriciples.Principles.Inheritance;
using OOPPriciples.Principles.Polymorphism;

namespace OOPPriciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
            BankAccount example = new BankAccount("Khaled", 6000);
	    //	Console.WriteLine(example.Balance+= 555);
         //   example.Deposit(500);
            example.Balance = 7
                ;
            ////////////////////////////////////////////////////////
            ///
           
            
            Animal lion1 = new Animal("Lion1", 15);

            //    8 byte      13 byte
            Animal lion2 = new Lion("Lion2", 16, "wwwwwww");
            // => Liskuv sub principle => self-study 


            Animal lion3;
            // refrence type does not take any space
            // untill it is initialized 

            lion3 = new Lion("Lion3", 17, "wwwwwww");

			// => why (refrence value) is stored at heap memory


			// logical syntax
			// Lion lion4 = new Animal("lion5", 6); 


		//	Console.WriteLine(lion2.GetInfo());
            ////////////////////////////////////
            ///





            Shape shape = new Circle(5);
            //  shape.PrintInfo();










            //         List<IDrawable> uiElements = [
            //             new Button{ Label= "Save"},
            //             new TextBox{PlaceHolder = "Username"},
            //             new Icon {IconName = "Star"}
            //             ];


            //foreach (var item in uiElements)
            //{
            //             // Polymorphism 
            //             item.Draw();
            //}

            Student khaled = new Student("Khaled");
			Student hassan = new Student("hass");

			Console.WriteLine(Student.TotalIncrements);
			// Student.TotalIncrements; 






			Car car = new Car() { Name = "Kia", Price =15};
			Console.WriteLine(Car.TiersCount);






           var x =  MathUtils.Pi;
            var c = MathUtils.CircleArea(16);
			Console.ReadLine();
		}
    }
}
