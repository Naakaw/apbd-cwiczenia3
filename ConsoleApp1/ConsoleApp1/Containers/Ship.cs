namespace ConsoleApp1.Containers;

public class Ship
{
    private List<Container> Containers;
    private double MaxSpeed;
    private int MaxContainersAmount;
    private double MaxLoadAmount;

    public Ship(double maxSpeed, int maxContainersAmount, double maxLoadAmount)
    {
        MaxSpeed = maxSpeed;
        MaxContainersAmount = maxContainersAmount;
        MaxLoadAmount = maxLoadAmount;
    }

    public void LoadContainer(Container container)
    {
        this.Containers.Add(container);
    }

    public void LoadListOfContainers(List<Container> containersList)
    {
        this.Containers.AddRange(containersList);
    }

    public void UnloadContainer(Container container)
    {
        this.Containers.Remove(container);
    }

    public void ReplaceContainer(String SerialNumber, Container newContainer)
    {
        foreach (Container originalContainer in Containers)
        {
            if (originalContainer.SerialNumber == SerialNumber)
            {
                Containers.Remove(originalContainer);
                Containers.Add(newContainer);
            }
        }
    }

    public void MoveToAnotherShip(Container container, Ship ship)
    {
        Containers.Remove(container);
        ship.LoadContainer(container);
    }

    public override string ToString()
    {
        String returnMessage = "Ship info: " +
                               "\nMax Speed (in knots): " + MaxSpeed +
                               "\nMax Amount of Carried Containers: " + MaxContainersAmount +
                               "\nMax Load Amount (in tons): " + MaxLoadAmount +
                               "\nLoaded containers: ";
        foreach (Container container in Containers)
        {
            returnMessage += container + ", ";
        }

        return returnMessage;
    }
}