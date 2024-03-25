namespace Tutorial3.Containers;

public class FreezerContainer : Container
{
    public FreezerContainer(double cargoWeight, double cargoHeight, double cargoSelfWeight, double cargoMaxWeight, double cargoDepth) : 
        base(cargoWeight, cargoHeight, cargoSelfWeight, cargoMaxWeight, cargoDepth)
    {
        ConType = "F";
        SerialNum = "KON-" + ConType+"-"+IdNum;
    }
    
}