namespace Tutorial3.Containers;

public class FreezerContainer : Container
{
    public string Product;
    public double Temperature;
    public FreezerContainer(double cargoWeight, double cargoHeight, double cargoSelfWeight, double cargoMaxWeight, double cargoDepth, string product) : 
        base(cargoHeight, cargoSelfWeight, cargoMaxWeight, cargoDepth)
    {
        Product = product;
        ConType = "F";
        SerialNum = "KON-" + ConType+"-"+IdNum;
    }

    public void Load(double cargoWeight)
    {
        switch(Product)
        {
         case "Bananas":
             Temperature = 13.3;
             break;
         case "Chocolate":
             Temperature = 18.0;
             break;
         case "Fish":
             Temperature = 2.0;
             break;
         case "Meat":
             Temperature = -15.0;
             break;
         case "Ice Cream":
             Temperature = -18.0;
             break;
         case "Frozen Pizza":
             Temperature = -30.0;
             break;
         case "Cheese":
             Temperature = 7.2;
             break;
         case "Sausages":
             Temperature = 5.0;
             break;
         case "Butter":
             Temperature = 20.5;
             break;
         case "Eggs":
             Temperature = 19.0;
             break;
         default:
             Temperature = 0;
             break;
        }
        base.Load(cargoWeight);
    }

    public override string ToString()
    {
        return "Waga ładunku -> "+CargoWeight +"kg "+ " Wysokość kontenera -> "+CargoHeight+"cm "+" Głębokość kontenera -> "+CargoDepth+"cm "+ " Waga konetenera -> "+CargoSelfWeight+"kg "+ " Maksymalna waga konetera -> "+CargoMaxWeight+"kg "+"Temperatura w kontenerze -> "+Temperature+" "+"Produkt"+Product+" "+SerialNum;
    }
}