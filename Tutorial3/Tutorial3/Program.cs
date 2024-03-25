using Tutorial3;
using Tutorial3.Containers;

class Program
{ 
    static void Main(string[]args)
    {
        List<CargoShip> cargoShips = new List<CargoShip>();
        List<Container> containers = new List<Container>();
        var End = false;
        while (!End)
        {
            Console.WriteLine("[0]Opcje kontenera [1]Stwórz statek [2]Opercaje na statku [3]zakończ aplikacje");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    var a = -1;
                    while(a!=2)
                    {
                        Console.WriteLine("[0]Stwórz kontener [1]Operuj na danym kontenerze [2]Wróć");
                        var choice1 = Console.ReadLine();
                        switch (choice1)
                        {
                            case "0":
                                Console.WriteLine("Rodzaj -> [0]GasContainer [1]LiquidContainer [2]FreezerContainer");
                                var choice2 = Console.ReadLine();
                                switch (choice2)
                                {
                                    case "0":
                                        GasContainer gc = new GasContainer(3,3,3,6,3,4,true);
                                        containers.Add(gc);
                                        Console.WriteLine("Stworzono kontener "+gc.SerialNum);
                                        break;
                                    case "1":
                                        LiquidContainer lc = new LiquidContainer(3, 3, 3, 6,  true);
                                        containers.Add(lc);
                                        Console.WriteLine("Stworzono kontener "+ lc.SerialNum);
                                        break;
                                    case "2":
                                        FreezerContainer fc = new FreezerContainer(3,3,3,3,3,"Bananas");
                                        containers.Add(fc);
                                        Console.WriteLine("Stworzono kontener "+ fc.SerialNum);
                                        break;
                                }
                                
                                break;
                            case "1":
                                if (containers.Count==0)
                                {
                                    break;
                                }
                                for (int i = 0; i < containers.Count; i++)
                                {
                                    Console.WriteLine("["+i+"]"+" "+containers[i].SerialNum);
                                }
                                var index = Console.ReadLine();
                                var conChosen = containers[int.Parse(index)];
                                Console.WriteLine("[0]Załaduj ładunek [1]Załaduj kontener na statek [2]Rozładuj kontener [3]Wypisz informacje o danym kontenerze [4]Wróć");
                                var choice3 = Console.ReadLine();
                                var b = -1;
                                while (b != 4)
                                {
                                    switch (choice3)
                                    {
                                        case "0":
                                            Console.WriteLine("Podaj wagę");
                                            var cargoWeight = Console.ReadLine();
                                            conChosen.Load(double.Parse(cargoWeight));
                                            break;
                                        case "1":
                                            if (cargoShips.Count==0)
                                            {
                                                break;
                                            }
                                            Console.WriteLine("Lista statków");
                                            for (int i = 0; i < cargoShips.Count; i++)
                                            {
                                                Console.WriteLine("["+i+"]"+" "+cargoShips[i]);
                                            }
                                            var index1 = Console.ReadLine();
                                            var cargoChosen = cargoShips[int.Parse(index1)];
                                            cargoChosen.CargoContainers.Add(conChosen);
                                            Console.WriteLine("Kontener dodano do statku o id "+cargoChosen.IdShip);
                                            b = 4;
                                            break;
                                        case "2":
                                            conChosen.Unload();
                                            break;
                                        case "3":
                                            Console.WriteLine(conChosen);
                                            b = 4;
                                            break;
                                        case "4":
                                            b = 4;
                                            break;
                                        default:
                                            b = 4;
                                            break;
                                    }
                                }
                                break;
                            case "2":
                                a = 2;
                                break;
                            default:
                                a = 2;
                                break;
                        }
                    }
                    break;
                case "1":
                    Console.WriteLine("podaj maks liczbe kontenerów");
                    var maxConNum = Console.ReadLine();
                    Console.WriteLine("podaj maks wage sumy kontenrów");
                    var maxConWeight = Console.ReadLine();
                    CargoShip cs = new CargoShip(30,int.Parse(maxConNum),int.Parse(maxConWeight));
                    cargoShips.Add(cs);
                    Console.WriteLine("Swtorzono statek");
                    break;
                case "2":
                    var c = -1;
                    if (cargoShips.Count==0)
                    {
                        break;
                    }
                    Console.WriteLine("Lista statków");
                    for (int i = 0; i < cargoShips.Count; i++)
                    {
                        Console.WriteLine("["+i+"]"+" "+cargoShips[i].IdShip);
                    }
                    var index3 = Console.ReadLine();
                    var cargoChosen1 = cargoShips[int.Parse(index3)];
                    while(c!=2) 
                    {
                        Console.WriteLine("[0]Zastąp kontener innym [1]Przenieś kontener na inny statek [2]wypisz informacje [3]Wróć");
                        var option = Console.ReadLine();
                        switch (option)
                        {
                            case "0":
                                if (cargoChosen1.CargoContainers.Count==0||containers.Count==0)
                                {
                                    break;
                                }
                                Console.WriteLine("Lista kontenerów na statku");
                                for (int i = 0; i < cargoChosen1.CargoContainers.Count; i++)
                                {
                                    Console.WriteLine(i+" -> "+cargoChosen1.CargoContainers[i].SerialNum);
                                }
                                Console.WriteLine("Wybierz kontener");
                                var conChosen1 = Console.ReadLine();
                                Console.WriteLine("Lista kontenerów wolncyh");
                                for (int i = 0; i < containers.Count; i++)
                                {
                                    Console.WriteLine(i+" -> "+containers[i].SerialNum);
                                }
                                Console.WriteLine("Wybierz kontener");
                                var conChosen2 = Console.ReadLine();
                                cargoChosen1.CargoContainers[int.Parse(conChosen1)] = containers[int.Parse(conChosen2)];
                                break;
                            case "1":
                                if (cargoChosen1.CargoContainers.Count==0)
                                {
                                    break;
                                }
                                Console.WriteLine("Lista kontenerów na statku");
                                for (int i = 0; i < cargoChosen1.CargoContainers.Count; i++)
                                {
                                    Console.WriteLine(i+" -> "+cargoChosen1.CargoContainers[i].SerialNum);
                                }
                                Console.WriteLine("Wybierz kontener");
                                var conChosen5 = Console.ReadLine();
                                Container con = cargoChosen1.CargoContainers[int.Parse(conChosen5)];
                                Console.WriteLine("Lista statków");
                                for (int i = 0; i < cargoShips.Count(); i++)
                                {
                                    Console.WriteLine(i+" -> "+cargoShips[i].IdShip);
                                }
                                Console.WriteLine("Wybierz statek");
                                var shipChosen = Console.ReadLine();
                                cargoShips[int.Parse(shipChosen)].CargoContainers.Add(con);
                                break;
                            case "2":
                                Console.WriteLine(cargoChosen1);
                                break;
                            case "3":
                                c = 3;
                                break;
                        }
                    }
                    break;
                case "3":
                    End = true;
                    break;
                default:
                    End = true;
                    break;
            }
        }
    }
}