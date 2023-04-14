using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class Car : IStore
	{
		public string CarName { get; set; }
		public double Price { get; set; }
		public void Visit(IVisitor visitor)
		{
			visitor.Accept(this);
		}
	}
}
