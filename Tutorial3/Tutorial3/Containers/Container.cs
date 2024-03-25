using Tutorial3.Exceptions;
using Tutorial3.Interfaces;

namespace Tutorial3.Containers;

public class Container : IContainer
{
    public double CargoWeight { get; set; }
    
    public Container(double cargoWeight)
    {
        CargoWeight = cargoWeight;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        Console.WriteLine("Container");
        CargoWeight = cargoWeight;
        // throw new OverfillException();
    }
}
