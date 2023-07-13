class RentalSystem {

    public RentalSystem(){
        
    }

    public int Price_of_rental(Vehicle item, int how_long){
        int price = item.GetPrice() * how_long;
        return price;
    }    

    public int GetInterger(string rent_choice){
        while (true){
            Console.Write($"How many days will you be renting the {rent_choice}? ");
            var length_stg = Console.ReadLine();

            try {
                var value = int.Parse(length_stg);
                return value;
            } catch(Exception){
                Console.WriteLine("Please enter a number");
            }                    

        }
    }
}