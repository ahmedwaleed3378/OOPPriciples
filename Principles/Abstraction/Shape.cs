using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPriciples.Principles.Abstraction
{
	internal abstract class Shape
	{
		public string Name { get; }
		protected Shape(string name) => Name = name;


		public abstract double Area();
		// abstract method - no implementation
		// each concreate chape MUST implement it
		public abstract double Perimeter();

		public void PrintInfo()
		{
			Console.WriteLine($"Shape: {Name}");
			Console.WriteLine($"Area {Area():F2}, Perimeter{Perimeter():F2}");
		}

	}



	internal class Circle: Shape
	{
		public double Radius { get; }
		public Circle(double radius):
		base("Circle")
		{
			Radius = radius;
		}
		public override double Area() =>
			Math.PI * Radius * Radius;
		public override double Perimeter() =>
			Math.PI * 2 * Radius;

	} 
}
