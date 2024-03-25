namespace Tutorial3.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoWeight, double cargoHeight, double cargoSelfWeight, double cargoMaxWeight, double cargoDepth) :
        base(cargoWeight, cargoHeight, cargoSelfWeight,cargoMaxWeight,cargoDepth)
    {
        ConType = "L";
        SerialNum = "KON-" + ConType+"-"+IdNum;
    }
    
    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
        Console.WriteLine("LiquidContainer");
    }
    
}