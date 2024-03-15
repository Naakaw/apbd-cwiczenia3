using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool isDangerous;
    private int initialMaxLoad;
    
    public LiquidContainer(int cargoWeight, int height, int overallWeight, int depth, int maxLoad) : base(cargoWeight, height, overallWeight, depth, maxLoad)
    {
        this.serialNumber = "CON-L-" + Container.NUMBER;
        Container.NUMBER++;
    }

    public override void Unload()
    {
        base.Unload();
    }

    public override void Load(int cargoWeight)
    {
        ChangeMaxLoad();
        try
        {
            base.Load(cargoWeight);
        }
        catch (OverfillException e)
        {
            Alert();
        }
        
    }

    public void Alert()
    {
        Console.WriteLine("Dangerous action");
    }

    public void Load(int cargoWeight, bool isDangerous)
    {
        this.isDangerous = isDangerous;
        Load(cargoWeight);
    }

    private void ChangeMaxLoad()
    {
        if (isDangerous)
        {
            maxLoad = initialMaxLoad / 2;
        }
        else
        {
            maxLoad = (int) (initialMaxLoad * 0.9);
        }
    }
}