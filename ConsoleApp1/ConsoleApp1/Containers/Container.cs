using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public abstract class Container : IContainer
{
    
    public int cargoWeight { get; set; }
    public int height { get; set; }
    public int overallWeight { get; set; }
    public int depth { get; set; }
    public string serialNumber { get; set; }
    public int maxLoad { get; set; }

    public static int NUMBER = 1;


    protected Container(int cargoWeight, int height, int overallWeight, int depth, int maxLoad)
    {
        this.cargoWeight = cargoWeight;
        this.height = height;
        this.overallWeight = overallWeight;
        this.depth = depth;
        this.maxLoad = maxLoad;
    }

    public virtual void Unload()
    {
        this.cargoWeight = 0;
    }

    public virtual void Load(int cargoWeight)
    {
        this.cargoWeight = cargoWeight;
        
        if (this.cargoWeight > this.maxLoad)
            throw new OverfillException("Overfill");
    }
}