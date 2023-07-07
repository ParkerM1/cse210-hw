class Truck: Vehicle {
    private int _wheelnum;
    private bool _needTruckLic;

    public Truck(string make, string model, string licenseNum, string year, int millage, int price, int wheelnum, bool needTruckLic): base(make, model, licenseNum, year, millage, price){
        _wheelnum = wheelnum;
        _needTruckLic = needTruckLic;
    }

    override public void Show_vehicle(){
        
    }
}