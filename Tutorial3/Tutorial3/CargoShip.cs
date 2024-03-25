using Tutorial3.Containers;

namespace Tutorial3;

public class CargoShip
{
    public List<Container>CargoContainers;
    public double Speed;
    public int MaxConNum;
    public double MaxConWeight;
    private static int _idNum=0;
    public int IdShip;

    public CargoShip(double speed, int maxConNum, double maxConWeight)
    {
        _idNum += _idNum;
        IdShip = _idNum;
        Speed = speed;
        MaxConNum = maxConNum;
        MaxConWeight = maxConWeight;
        CargoContainers = new List<Container>(maxConNum);
    }

    public override string ToString()
    {
        if (CargoContainers.Count==0)
        {
            for (int i = 0; i < CargoContainers.Count; i++)
            {
                Console.WriteLine("1 -> "+CargoContainers[i]);
            }
        }
        else
        {
            Console.WriteLine("Kontenerowiec nie ma kontenerów");
        }

        return "Speed "+Speed+" węzłów "+"Maksymalna liczba kontenrów "+MaxConNum+" Maksymalna waga wszystkich kontenrów "+MaxConWeight+"kg "+IdShip+" Id number";
    }
}