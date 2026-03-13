using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPriciples.Advanced
{
	///<summary>
	/// SEALED: Prevents furhter inheritance or overriding.
	/// sealed class, No Class can inherit from it (string)
	/// used when we want to lock down a type or a method for security,
	/// performance or design logic
	///</summary>	
	public  class Vehicle
	{
		public virtual void Start() => Console.WriteLine("Vehicle Starting....");
		public virtual string GetTypeName() => "Vehicle";
	}

	public class CarType: Vehicle
	{
		public override void Start() => Console.WriteLine("Car Engine ..");
		public override string GetTypeName() => "Car";

	}
	public sealed class SportsCar : Vehicle
	{
		public override void Start() => Console.WriteLine("SportsCar Engine {secret move}..");
		public override string GetTypeName() => "SportsCar";
	}
}
