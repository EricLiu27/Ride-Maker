
Vehicle car = new Vehicle("Toyota Highlander", 5, "blue", true, 60);
Vehicle bus = new Vehicle("School Bus", 26, "yellow", true, 20);
Vehicle racecar = new Vehicle("Nascar", "red");
Vehicle skateboard = new Vehicle("Skateboard", 1, "black", false, 4);


List<Vehicle> AllVehicles = new List<Vehicle>();
AllVehicles.Add(car);
AllVehicles.Add(bus);
AllVehicles.Add(racecar);
AllVehicles.Add(skateboard);


foreach (Vehicle type in AllVehicles)
{
    type.ShowInfo();
}

car.Travel(100);
car.ShowInfo();