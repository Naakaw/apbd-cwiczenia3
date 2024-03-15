namespace ConsoleApp1.Interfaces;

public interface IContainer
{
    public void Unload();
    public void Load(int cargoWeight);
}