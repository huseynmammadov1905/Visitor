
using Visitor;

List<IStore> stores = new List<IStore>();

IStore car = new Car() { CarName = "Nissan", Price = 100 };
IStore mtr = new Motorcycle() { MotorcycleName = "Bmw", Price = 50 };


PriceVisitor visitor = new PriceVisitor();

car.Visit(visitor);
mtr.Visit(visitor);