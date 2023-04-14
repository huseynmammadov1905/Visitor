using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class Motorcycle : IStore
	{
		public string MotorcycleName { get; set; }
		public double Price { get; set; }
		public void Visit(IVisitor visitor)
		{
			visitor.Accept(this);
		}
	}
}
