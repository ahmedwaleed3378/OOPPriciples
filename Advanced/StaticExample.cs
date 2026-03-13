using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPriciples.Advanced
{
	internal class Student
	{
		public string Name { get; set; }
		public static int TotalIncrements { get; private set; } = 0;

	public	Student (string name)
		{
			Name = name;
			TotalIncrements++;
		}

	}



	public class Car
	{
		public string Name { get; set; }
		= string.Empty; // 10 byte
		public int Price { get; set; } // 4 byte
		// static members(data) are one copy shared by all instances 
		public static int TiersCount { get; set; } =4;
	}

	// static class: no instance, only static members 
	// static classes cannot be instantiated only 
	// mainly used for helper/utils classes 

	public static class MathUtils
	{
		public const double Pi = 3.14;

		public static double CircleArea(double rad) => Pi * rad * rad;
	}


}
