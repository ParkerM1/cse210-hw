class Motorcycle: Vehicle{
    private string _type;

    public Motorcycle(string make, string model, string licenseNum, string year, int millage, int price, string available, string type): base(make, model, licenseNum, year, millage, price, available){
        _type = type;
    }

    public string GetNewType(){
        return _type;
    }
    override public void ShowVehicle(){
        Console.WriteLine("Avablible: " + GetAvailable() + " | Make: " + GetMake() + " | Model: " + GetModel() + " | Year: " + GetYear() + " | Millage: " + GetMillage() + " | License Number " + GetLicenseNum() + " | Price Per Day: $" + GetPrice() + " | Type of motorcycle: " + GetType());
    }
}