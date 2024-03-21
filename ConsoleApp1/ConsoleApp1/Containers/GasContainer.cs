using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(int cargoWeight, int height, int overallWeight, int depth, int maxLoad) : base(cargoWeight, height, overallWeight, depth, maxLoad)
    {
        this.SerialNumber = "CON-G-" + Container.NUMBER;
        Container.NUMBER++;
    }

    public void Alert()
    {
        Console.WriteLine("Dangerous action, container no. " + this.SerialNumber);   
    }

    public override void Unload()
    {
        this.CargoWeight = (int)(0.05 * this.CargoWeight);
    }
}