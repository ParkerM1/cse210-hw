using System;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> _vehicleList = new List<Vehicle>();
        Vehicle vehicle = new Vehicle();
        Vehicle vehicle1 = new Car("Toyota", "Camry", "Y56GHI", "2022", 4000, 40, "Yes", "sedan");
        _vehicleList.Add(vehicle1);
        Vehicle vehicle2 = new Car("BMW", "X5", "Y53TYI", "2023", 7000, 50, "No", "sedan");
        _vehicleList.Add(vehicle2);
        Vehicle vehicle3 = new Motorcycle("Honda", "CBR600RR", "G45YU2", "2022", 1000, 30, "Yes", "Sport Bike");
        _vehicleList.Add(vehicle3);
        Vehicle vehicle4 = new Motorcycle("Harley-Davidson", "Street Glide", "YU56IO", "2023", 5000, 25, "No", "Touring");
        _vehicleList.Add(vehicle4);
        Vehicle vehicle5 = new Truck("Ford", "F-150", "PJK78R", "2022", 7000, 60, "Yes", 4, "No");
        _vehicleList.Add(vehicle5);
        Vehicle vehicle6 = new Truck("Chevrolet", "Silverado 1500", "JNG67", "2023", 8000, 65, "No", 4, "No");
        _vehicleList.Add(vehicle6);
        string user_choice = "4";
        while (user_choice != "3"){
            Console.WriteLine("Welcome to the Rexburg student rental service!");
            Console.WriteLine("");
            Console.WriteLine("1. See which vehicles are available");
            Console.WriteLine("2. See how much it would be to rent a vehicle");
            Console.WriteLine("3. quit");
            Console.WriteLine("");
            Console.Write("What would you like to do? ");
            user_choice = Console.ReadLine();
            if (user_choice == "1"){
                foreach (Vehicle item in _vehicleList){
                    item.ShowVehicle();
                    Console.WriteLine("");
                }
            }
            else if (user_choice == "2"){
                foreach (Vehicle item in _vehicleList){
                    if (item.GetAvailable() == "Yes"){
                        item.ShowVehicle();
                        Console.WriteLine("");
                    }
                }
                bool real_car = false;
                while (real_car == false){
                    bool car_rent = false;
                    while (car_rent == false){
                        Console.Write("Which vehicle would you like to rent(Please enter the model of the car)? ");
                        string rent_choice = Console.ReadLine();                    
                        foreach (Vehicle item in _vehicleList){
                            if ((rent_choice == item.GetModel()) & (item.GetAvailable() == "Yes")){
                                RentalSystem rentalSystem = new RentalSystem();
                                int length = rentalSystem.GetInterger(rent_choice);
                                int price = rentalSystem.Price_of_rental(item, length); 
                                Console.WriteLine($"To rent the {rent_choice} for {length} days it will cost ${price}");
                                Console.Write("Would you like to rent the vehicle (yes or no)? ");
                                string to_rent = Console.ReadLine();
                                if (to_rent == "yes"){
                                    Console.WriteLine("Great your reservation has been recorded");
                                    car_rent = true;
                                    real_car = true;
                                    user_choice = "3";
                                }
                                else if (to_rent == "no"){
                                    car_rent = true;
                                    real_car = true;
                                }
                            else{
                                Console.WriteLine("");
                                Console.WriteLine("You did not enter a valid vehicle or one that is avablible");
                                Console.WriteLine("");
                            }
                            }
                        }

                    }
                }
            }
            else if (user_choice == "3"){
                Console.WriteLine("Thank you for using Rexburg student rental service!");
            }
            else{
                Console.WriteLine("");
                Console.WriteLine("You did not enter a correct input. Please try again.");
                Console.WriteLine("");
            } 
        }
    }
}