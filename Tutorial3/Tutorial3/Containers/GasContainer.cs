namespace Tutorial3.Containers;

public class GasContainer : Container
{
    public double Pressure;
    public GasContainer(double cargoWeight, double cargoHeight, double cargoSelfWeight, double cargoMaxWeight, double cargoDepth, double pressure) : 
        base(cargoWeight, cargoHeight, cargoSelfWeight, cargoMaxWeight, cargoDepth)
    {
        Pressure = pressure;
        ConType = "G";
        SerialNum = "KON-" + ConType+"-"+IdNum;
    }
    
}