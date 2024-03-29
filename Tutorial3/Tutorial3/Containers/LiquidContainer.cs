﻿using Tutorial3.Exceptions;
using Tutorial3.Interfaces;

namespace Tutorial3.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool HazardCargo;
    public LiquidContainer(double cargoHeight, double cargoSelfWeight, double cargoMaxWeight, double cargoDepth,bool hazardCargo) :
        base(cargoHeight, cargoSelfWeight,cargoMaxWeight,cargoDepth)
    {
        HazardCargo = hazardCargo;
        ConType = "L";
        SerialNum = "KON-" + ConType+"-"+IdNum;
    }
    
    public override void Load(double cargoWeight)
    {
        if (HazardCargo)
        {
            CargoMaxWeight = CargoMaxWeight / 2;
            if (cargoWeight>CargoMaxWeight)
            {
                Notification();
                throw new OverfillException();
            }else{base.Load(cargoWeight);}
        }
        else
        {
            CargoMaxWeight = CargoMaxWeight * 0.9;
            if (cargoWeight>CargoMaxWeight)
            {
                Notification();
                throw new OverfillException();
            }
            else{base.Load(cargoWeight);}
        }
    }
    
    public void Notification()
    {
        Console.WriteLine("Niebiezpiecnza sytuacja -> "+SerialNum);
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "Waga ładunku -> "+CargoWeight +"kg "+ " Wysokość kontenera -> "+CargoHeight+"cm "+" Głębokość kontenera -> "+CargoDepth+"cm "+ " Waga konetenera -> "+CargoSelfWeight+"kg "+ " Maksymalna waga konetera -> "+CargoMaxWeight+"kg "+ "Czy towar jest niebezpiczny? -> "+HazardCargo+" "+SerialNum;
    }
}