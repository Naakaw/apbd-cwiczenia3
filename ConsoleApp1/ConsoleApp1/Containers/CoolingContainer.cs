namespace ConsoleApp1.Containers;

public class CoolingContainer : Container
{
    public Products ContainedProduct { get; set; }
    public double Temperature { get; set; }


    public CoolingContainer(int cargoWeight, int height, int overallWeight, int depth, int maxLoad) : base(cargoWeight, height, overallWeight, depth, maxLoad)
    {
        this.SerialNumber = "CON-C-" + Container.NUMBER;
        Container.NUMBER++;
    }

    public void Load(int cargoWeight, Products productType)
    {
        switch (productType)
        {
            case Products.Bananas:
                this.Temperature = 13.3;
                break;
            case Products.Chocolate:
                this.Temperature = 18;
                break;
            case Products.Fish:
                Temperature = 2;
                break;
            case Products.Meat:
                Temperature = -15;
                break;
            case Products.IceCream:
                Temperature = -18;
                break;
            case Products.FrozenPizza:
                Temperature = -30;
                break;
            case Products.Cheese:
                Temperature = 7.2;
                break;
            case Products.Sausages:
                Temperature = 5;
                break;
            case Products.Butter:
                Temperature = 20.5;
                break;
            case Products.Eggs:
                Temperature = 19;
                break;
            default:
                Temperature = 0;
                break;
        }
        
        Load(cargoWeight);
    }
}