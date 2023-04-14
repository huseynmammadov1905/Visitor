using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public interface IVisitor
	{
		void Accept(Car car);
		void Accept(Motorcycle bike);
	}
}
