using Tutorial3.Exceptions;
using Tutorial3.Interfaces;

namespace Tutorial3.Containers;

public class Container : IContainer
{
    public double CargoWeight {get; set;}
    public double CargoHeight {get; set;}
    public double CargoSelfWeight {get; set;}
    public double CargoDepth {get; set;}
    public double CargoMaxWeight { get; set; }
    public static int IdNum = 0;
    public String ConType = "C";
    public String SerialNum { get; set; }

    public Container(double cargoWeight, double cargoHeight, double cargoSelfWeight, double cargoMaxWeight, double cargoDepth)
    {
        IdNum += 1;
        SerialNum = "KON-" + ConType+"-"+IdNum;
        CargoSelfWeight = cargoSelfWeight;
        CargoMaxWeight = cargoMaxWeight;
        CargoDepth = cargoDepth;
        CargoWeight = cargoWeight;
        CargoHeight = cargoHeight;
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
