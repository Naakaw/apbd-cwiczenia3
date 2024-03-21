using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public abstract class Container : IContainer
{
    
    public int CargoWeight { get; set; }
    public int Height { get; set; }
    public int OverallWeight { get; set; }
    public int Depth { get; set; }
    public string SerialNumber { get; set; }
    public int MaxLoad { get; set; }

    public static int NUMBER = 1;


    protected Container(int cargoWeight, int height, int overallWeight, int depth, int maxLoad)
    {
        this.CargoWeight = cargoWeight;
        this.Height = height;
        this.OverallWeight = overallWeight;
        this.Depth = depth;
        this.MaxLoad = maxLoad;
    }

    public virtual void Unload()
    {
        this.CargoWeight = 0;
    }

    public virtual void Load(int cargoWeight)
    {
        this.CargoWeight = cargoWeight;
        
        if (this.CargoWeight > this.MaxLoad)
            throw new OverfillException("Overfill");
    }

    public override string ToString()
    {
        return SerialNumber;
    }
}