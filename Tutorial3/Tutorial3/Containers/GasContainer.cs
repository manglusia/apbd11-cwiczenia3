namespace Tutorial3.Containers;

public class GasContainer : Container
{
    public GasContainer(double cargoWeight, double cargoHeight, double cargoSelfWeight, double cargoMaxWeight, double cargoDepth) : 
        base(cargoWeight, cargoHeight, cargoSelfWeight, cargoMaxWeight, cargoDepth)
    {
        ConType = "G";
        SerialNum = "KON-" + ConType+"-"+IdNum;
    }
    
}