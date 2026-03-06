using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPriciples.Principles.Inheritance
{ 
	internal class Animal //8 byte
	{
		public string Name { get; set; } = "Lion"; // 1 character = 1 byte 
		public int Age { get; set; } // 4 byte 

		public virtual void Sound() =>
			Console.WriteLine($"{Name} makes a sound ");
		public Animal(string name, int age)
		{

			Name = name;
			Age = age;
		}


		public virtual string GetInfo() => $"my name is {Name}, and i am {Age} ";
	}
	internal class Lion : Animal // 8 byte +5 = 13
	{
		public string Beard;// 5 byte
		public Lion(string name, int age, string beard ) :
		base(name, age)
		{
			Beard = beard;
		}

		public override void Sound()
		{
			Console.WriteLine($"{Name} Lion makes a sound ");

		}

		public override string GetInfo()
		{
			return base.GetInfo() + "i have a beard";
		}
	}

}
