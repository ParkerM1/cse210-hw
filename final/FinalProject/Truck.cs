class Truck: Vehicle {
    private int _wheelnum;
    private string _needTruckLic;

    public Truck(string make, string model, string licenseNum, string year, int millage, int price, string available, int wheelnum, string needTruckLic): base(make, model, licenseNum, year, millage, price, available){
        _wheelnum = wheelnum;
        _needTruckLic = needTruckLic;
    }

    public int GetWheelNum (){
        return _wheelnum;
    }

    public string GetNeedTruckLic (){
        return _needTruckLic;
    }

    override public void ShowVehicle(){
        Console.WriteLine("Avablible: " + GetAvailable() + " | Make: " + GetMake() + " | Model: " + GetModel() + " | Year: " + GetYear() + " | Millage: " + GetMillage() + " | License Number " + GetLicenseNum() + " | Price Per Day: $" + GetPrice() + " | Number of wheels: " + GetWheelNum() + " | Need truck license? " + GetNeedTruckLic());
    }
}