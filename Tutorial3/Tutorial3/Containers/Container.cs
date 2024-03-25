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
    public string ConType = "C";
    public string SerialNum { get; set; }

    public Container(double cargoHeight, double cargoSelfWeight, double cargoMaxWeight, double cargoDepth)
    {
        CargoWeight = 0;
        IdNum += 1;
        SerialNum = "KON-" + ConType+"-"+IdNum;
        CargoSelfWeight = cargoSelfWeight;
        CargoMaxWeight = cargoMaxWeight;
        CargoDepth = cargoDepth;
        CargoHeight = cargoHeight;
    }

    public void Unload()
    {
        CargoWeight = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        CargoWeight = cargoWeight;
        // throw new OverfillException();
    }

    public override string ToString()
    {
        return " "+SerialNum;
    }
}
