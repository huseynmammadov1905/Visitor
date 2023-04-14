using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class PriceVisitor : IVisitor
	{
		const int CarDiscount = 10;
		const int MotorcycleDiscount = 5;

		public void Accept(Car car)
		{
			double carPriceAfterDicount = car.Price - car.Price / 20 * CarDiscount;
			Console.WriteLine("Car {0} price: {1}", car.CarName, carPriceAfterDicount);
		}

		public void Accept(Motorcycle bike)
		{
			double mtrPriceAfterDicount = bike.Price - bike.Price / 30 * MotorcycleDiscount;
			Console.WriteLine("Motorcycle {0} price: {1}", bike.MotorcycleName, mtrPriceAfterDicount);
		}
	}
}
