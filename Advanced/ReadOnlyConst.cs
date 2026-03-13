using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPriciples.Advanced
{
	internal class ConstantsDemo
	{
		public const int MaxItems = 100; // compile-time: same for all instances 
		// set in ctor; can differ per instance
		public readonly DateTime CreatedAt;// late // can be set during runtime 

		public ConstantsDemo(DateTime? createdAt= null)
		{
			
			CreatedAt = createdAt ?? DateTime.UtcNow;
			//if (createdAt != null)
			//{
			//	CreatedAt = createdAt;
			//}
			//else
			//{
			//	CreatedAt = DateTime.UtcNow;
			//}
		}

	}
}
