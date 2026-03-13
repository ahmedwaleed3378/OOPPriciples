using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPriciples.Principles.Polymorphism
{
	/// <summary>
	/// interfaces present specific behavior in your system
	/// 
	/// Polymorphism: the ability of objects to take many forms.
	//   Same behavior or base type, different concrete class
	/// </summary>
	public interface IDrawable
	{
		void Draw();
	}




	public interface IClickable
	{
		void Click();
	}


	public interface IMoveable
	{
		void Click();
	}


	public class Button: IDrawable, IClickable, IMoveable
	{
		public string Label { get; set; } = "Click";



		void IClickable.Click() => Console.WriteLine("[Button] Clicked");

		void IMoveable.Click() => Console.WriteLine("[Button] Moved");

		public void Draw() => Console.WriteLine($"[Button] Drawing button with lable \"{Label}\"");
	}

	public class TextBox:IDrawable
	{
		public string PlaceHolder { get; set; } = "Enter Text ...";
		public void Draw() => Console.WriteLine($"[TextBox] Drawing textbox with lable \"{PlaceHolder}\"");
	}

	public class Icon : IDrawable, IClickable
	{
		public string IconName { get; set; } = "Star";



		public void Click() => Console.WriteLine("[Icon] Clicked");

		public void Draw() => Console.WriteLine($"[Icon] Drawing Icon with lable \"{IconName}\"");
	}
}
