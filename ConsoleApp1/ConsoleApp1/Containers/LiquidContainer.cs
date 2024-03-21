using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool _isDangerous;
    private int _initialMaxLoad;
    
    public LiquidContainer(int cargoWeight, int height, int overallWeight, int depth, int maxLoad) : base(cargoWeight, height, overallWeight, depth, maxLoad)
    {
        this.SerialNumber = "CON-L-" + Container.NUMBER;
        Container.NUMBER++;

        _initialMaxLoad = maxLoad;
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
        Console.WriteLine("Dangerous action, container no. " + this.SerialNumber);   
    }

    public void Load(int cargoWeight, bool isDangerous)
    {
        this._isDangerous = isDangerous;
        Load(cargoWeight);
    }

    private void ChangeMaxLoad()
    {
        if (_isDangerous)
        {
            MaxLoad = _initialMaxLoad / 2;
        }
        else
        {
            MaxLoad = (int) (_initialMaxLoad * 0.9);
        }
    }
}