using Tutorial3.Containers;

namespace Tutorial3;

public class CargoShip
{
    public Container[] containers;
    public double Speed;
    public int MaxConNum;
    public double MaxConWeight;

    public CargoShip(double speed, int maxConNum, double maxConWeight)
    {
        Speed = speed;
        MaxConNum = maxConNum;
        MaxConWeight = maxConWeight;
        containers = new Container[maxConNum];
    }
}