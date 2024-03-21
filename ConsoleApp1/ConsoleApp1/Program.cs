using System.Net;
using ConsoleApp1.Containers;
using ConsoleApp1.Interfaces;
using Container = System.ComponentModel.Container;

Ship ship1 = new Ship(1.3, 300, 20000);
Ship ship2 = new Ship(0.9, 600, 60000);
Ship ship3 = new Ship(1.7, 150, 12000);

List<Ship> shipList = new List<Ship>();
shipList.Add(ship1);
shipList.Add(ship2);
shipList.Add(ship3);

Random random = new Random();
for (int i = 0; i < 10; i++)
{
    LiquidContainer liquidContainer = new LiquidContainer(random.Next(), random.Next(), random.Next(), random.Next(), random.Next());
    liquidContainer.Load(10, true);
    CoolingContainer coolingContainer = new CoolingContainer(random.Next(), random.Next(), random.Next(), random.Next(), random.Next());
    coolingContainer.Load(20, Products.Bananas);
    GasContainer gasContainer = new GasContainer(random.Next(), random.Next(), random.Next(), random.Next(), random.Next());
    gasContainer.Load(10);
    shipList[i % shipList.Count].LoadContainer(gasContainer);
    shipList[i % shipList.Count].LoadContainer(liquidContainer);
    shipList[i % shipList.Count].LoadContainer(coolingContainer);
}

Console.WriteLine(ship1);

ship1.ReplaceContainer(ship1.Containers[0].SerialNumber, new GasContainer(10, 10, 10, 10, 10));

Console.WriteLine(ship2);

ship1.MoveToAnotherShip(ship1.Containers[0], ship2);

Console.WriteLine(ship2);