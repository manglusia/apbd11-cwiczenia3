﻿using Tutorial3.Exceptions;
using Tutorial3.Interfaces;

namespace Tutorial3.Containers;

public class GasContainer : Container, IHazardNotifier
{
    public bool HazardCargo;
    public double Pressure;
    public GasContainer(double cargoWeight, double cargoHeight, double cargoSelfWeight, double cargoMaxWeight, double cargoDepth, double pressure, bool hazardCargo) : 
        base(cargoHeight, cargoSelfWeight, cargoMaxWeight, cargoDepth)
    {
        HazardCargo = hazardCargo;
        Pressure = pressure;
        ConType = "G";
        SerialNum = "KON-" + ConType+"-"+IdNum;
    }

    public new void Unload()
    {
        CargoWeight = CargoWeight * 0.05;
    }

    public override void Load(double cargoWeight)
    {
        if (HazardCargo)
        {
            if (cargoWeight>CargoMaxWeight)
            {
                Notification();
                throw new OverfillException();
            }else{base.Load(cargoWeight);}
        }
    }

    public void Notification()
    {
        Console.WriteLine("Niebiezpiecnza sytuacja -> "+SerialNum);
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "Waga ładunku -> "+CargoWeight +"kg "+" Wysokość kontenera -> "+CargoHeight+"cm "+" Głębokość kontenera -> "+CargoDepth+"cm "+" Waga konetenera -> "+CargoSelfWeight+"kg "+" Maksymalna waga konetera -> "+CargoMaxWeight+"kg "+ "Czy towar jest niebezpiczny? -> "+HazardCargo+" "+Pressure+"atmosfer "+SerialNum;
    }
}